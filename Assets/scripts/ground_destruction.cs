using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_destruction : MonoBehaviour
{
    private GameObject point;

    void Start()
    {
        point = GameObject.Find("Ground End Point");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < point.transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }
}
