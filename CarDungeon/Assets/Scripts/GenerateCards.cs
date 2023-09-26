using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateCards : MonoBehaviour
{
    public GameObject[] blocks = new GameObject[5];
    public GameObject logic;
    GameObject card;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<3; i++)
        {
            card = Instantiate(blocks[Random.Range(0, 6)], new Vector3(i - 1, -4, 0),this.transform.rotation);
            card.GetComponent<DragnDrop>().go = logic;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
