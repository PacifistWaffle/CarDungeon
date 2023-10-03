using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling;
using UnityEngine;

public class movement : MonoBehaviour
{


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -0.1f, 0);
        }

    
    }
}
