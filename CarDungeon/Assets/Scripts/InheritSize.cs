using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritSize : MonoBehaviour
{
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        logic comp = go.GetComponent<logic>();
        this.transform.localScale=new Vector2(comp.boardWidth*(float)2+(float)1.5,comp.boardHeight*(float)2+(float)1.5);
    }
}