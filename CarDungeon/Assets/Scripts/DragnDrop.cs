using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    bool overlap;
    bool dragging;
    BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        overlap = false;
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (collider == Physics2D.OverlapPoint(mousepos))
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
            this.transform.position = mousepos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            overlap = false;
            dragging = false;
        }
    }
}
