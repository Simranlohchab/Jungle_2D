using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling_background : MonoBehaviour
{
    public Renderer background;

    public float backgroundSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        background.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
