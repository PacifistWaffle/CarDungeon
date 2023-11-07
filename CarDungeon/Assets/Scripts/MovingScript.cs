using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private bool oneTime = false;

    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float Horizontal = Input.GetAxis ("Horizontal");
        float Vertical = Input.GetAxis ("Vertical");


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (oneTime == false)
            {
                rb.rotation = 90;
                oneTime = true;
            }
            else
            {
                oneTime = false;
            }

        }
        else
        {
            rb.rotation = 0;
        } 
        rb.velocity = new Vector2 (Horizontal * speed, Vertical * speed);
    }
}
