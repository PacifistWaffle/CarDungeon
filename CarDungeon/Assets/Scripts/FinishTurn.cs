using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FinishTurn : MonoBehaviour
{
    GameObject[] blocks;
    public GameObject logic;
    logic comp;

    private void Start()
    {
        comp=logic.GetComponent<logic>();
    }

    public void OnClick()
    {
        blocks = GameObject.FindGameObjectsWithTag("drawPile");
        for(int i=0; i<blocks.Length; i++)
        {
            if (blocks[i].GetComponent<DragnDrop>().changeTag == true)
            {
                blocks[i].tag="placedCard";
                blocks[i].GetComponent<DragnDrop>().enabled = false;
                comp.lockedposition.Add(blocks[i].transform.position);
            }
            else
            {
                Destroy(blocks[i]);
            }
        }
    }
}
