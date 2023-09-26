using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class drawCards : MonoBehaviour
{
    public GameObject CP = GameObject.FindWithTag("drawPile");

    void Start()
    {
        CP.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }

    void Update()
    {

    }

    private void OnMouseOver()
    {
       
    }
}
