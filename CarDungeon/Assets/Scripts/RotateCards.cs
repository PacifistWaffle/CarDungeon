using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateCards : MonoBehaviour
{
    public bool oneTime = false;

    void Start()
    {

    }


    void Update()
    {

    }

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.A) && oneTime == false)
        {
            transform.Rotate(Vector3.forward * 90);
            oneTime = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && oneTime == false)
        {
            transform.Rotate(Vector3.back * 90);
            oneTime = true;
        }
        else
        {
            oneTime = false;
        }
    }

}
