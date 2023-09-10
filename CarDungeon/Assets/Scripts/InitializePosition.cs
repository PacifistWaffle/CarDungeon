using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitilalizePosition : MonoBehaviour
{

    [SerializeField] GameObject prefab;

    void Start()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        pos.z = 0f;
        Instantiate(prefab, pos, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
