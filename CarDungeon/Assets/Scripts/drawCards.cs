using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class drawCards : MonoBehaviour
{
    public GameObject[] blocks = new GameObject[5];
    public GameObject logic;
    GameObject card;
    public void OnButtonPress()
    {
        for (int i = 0; i < 3; i++)
        {
            card = Instantiate(blocks[Random.Range(0, 5)], new Vector3(i - 1, -4, 0), this.transform.rotation);
            card.GetComponent<DragnDrop>().go = logic;
        }
    }
}
