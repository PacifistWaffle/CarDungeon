using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    bool overlap;
    bool dragging;
    BoxCollider2D bcollider;

    public int boardWidth=2;
    public int boardHeight=2;

    // Start is called before the first frame update
    void Start()
    {
        bcollider = GetComponent<BoxCollider2D>();
        overlap = false;
        dragging = false;
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
            if (overlap) { 
                dragging = true;
            }
        }

        if (dragging)
        {
            if(Mathf.Abs(mousepos.x)<=boardWidth && Mathf.Abs(mousepos.y)<=boardHeight)
            {
                mousepos = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y));
            }
            this.transform.position =mousepos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            overlap = false;
            dragging = false;
        }
    }
}
