using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class InheritSize : MonoBehaviour
{
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        logic comp = go.GetComponent<logic>();
        if(comp.boardHeight % 2 == 1) comp.boardHeight++;
        if (comp.boardWidth % 2 == 1) comp.boardWidth++;
        this.transform.localScale=new Vector2(comp.boardWidth*(float)2+(float)2,comp.boardHeight*(float)2+(float)2);
    }
}