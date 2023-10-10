using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTurn : MonoBehaviour
{
    GameObject[] blocks;

    public void OnClick()
    {
        blocks = GameObject.FindGameObjectsWithTag("drawPile");
        for(int i=0; i<blocks.Length; i++)
        {
            if (blocks[i].GetComponent<DragnDrop>().changeTag == true)
            {
                blocks[i].tag="placedCard";
                blocks[i].GetComponent<DragnDrop>().enabled = false;
            }
            else
            {
                Destroy(blocks[i]);
            }
        }
    }
}
