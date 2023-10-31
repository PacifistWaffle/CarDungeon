using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float Horizontal = Input.GetAxis ("Horizontal");
        float Vertical = Input.GetAxis ("Vertical");

        rb.velocity = new Vector2 (Horizontal * speed, Vertical * speed);
    }
}
