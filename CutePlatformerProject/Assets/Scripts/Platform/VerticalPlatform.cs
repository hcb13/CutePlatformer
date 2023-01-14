using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D platform;


    private void Awake()
    {
        platform = GetComponent<PlatformEffector2D>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            platform.rotationalOffset = 0f;
        }

        if(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow))
        {
            platform.rotationalOffset = 180f;
        }
        
        if(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow))
        {
            platform.rotationalOffset = 0f;
        }

    }

}
