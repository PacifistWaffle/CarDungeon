using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TurnPolygonsOn : MonoBehaviour
{
    GameObject card;
    PolygonCollider2D poly;
    BoxCollider2D box;

    public void OnButtonPress()
    {
        card = GameObject.FindGameObjectWithTag("placedCard");
        poly = card.GetComponent<PolygonCollider2D>();
        box = card.GetComponent<BoxCollider2D>();

        box.enabled = false;
        poly.enabled = true;
    }
}
