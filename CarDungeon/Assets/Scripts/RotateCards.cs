using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateCards : MonoBehaviour
{
    bool oneTime = false;

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Q) && oneTime == false)
        {
            transform.Rotate(Vector3.forward * 90);
            oneTime = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && oneTime == false)
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
