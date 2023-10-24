using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TurnPolygonsOn : MonoBehaviour
{
    GameObject[] card;
    PolygonCollider2D[] poly;
    BoxCollider2D box;

    public void OnButtonPress()
    {
        card = GameObject.FindGameObjectsWithTag("placedCard");

        for(int i=0; i<card.Length; i++)
        {
            poly = card[i].GetComponents<PolygonCollider2D>();
            box = card[i].GetComponent<BoxCollider2D>();

            box.enabled = false;
            for(int x=0; x<poly.Length; x++)
            {
                poly[x].enabled = true;
            }

        }

    }
}
