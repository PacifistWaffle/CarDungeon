using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    bool overlap;
    bool dragging;
    bool placed;
    BoxCollider2D bcollider;

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
            if (Mathf.Abs(mousepos.x) <= comp.boardWidth && Mathf.Abs(mousepos.y) <= comp.boardHeight && Array.IndexOf(comp.lockedposition, new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y)))==-1)
            {
                mousepos = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y));
            }
            this.transform.position = mousepos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            overlap = false;
            dragging = false;
        }
    }
}
