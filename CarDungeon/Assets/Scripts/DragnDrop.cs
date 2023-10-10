using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    public bool changeTag = false;
    bool snapped = false;
    bool overlap;
    bool dragging;
    bool placed;
    BoxCollider2D bcollider;
    Vector2 starting_position;

    public GameObject go;
    logic comp;

    // Start is called before the first frame update
    void Start()
    {
        bcollider = GetComponent<BoxCollider2D>();
        comp = go.GetComponent<logic>();
        overlap = false;
        dragging = false;
        placed = false;
        starting_position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (bcollider == Physics2D.OverlapPoint(mousepos))
            {
                overlap = true;
            }
            else
            {
                overlap = false;
            }
            if (overlap && !placed) { 
                dragging = true;
            }
        }

        if (dragging)
        {
            if (Mathf.Abs(mousepos.x) <= comp.boardWidth && Mathf.Abs(mousepos.y) <= comp.boardHeight && Array.IndexOf(comp.lockedposition, new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y))) == -1)
            {
                mousepos = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y));
                snapped = true;
            }
            else snapped = false;
            this.transform.position = mousepos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(snapped)
            {
                changeTag = true;
            }
            else
            {
                this.transform.position=starting_position;
            }
            overlap = false;
            dragging = false;
        }
    }
}
