using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{

    private void Awake()
    {
        GetComponent<CheckPlatform>().PlayerOnPlatform += OnPlatform;    
    }

    private void OnPlatform(bool isOnPlatform, Transform platform)
    {
        if(isOnPlatform)
        {
            gameObject.transform.SetParent(platform);
        }
        else
        {
            gameObject.transform.SetParent(null);
        }
    }




}
