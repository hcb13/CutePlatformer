using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlatform : MonoBehaviour
{
    public Action<bool, Transform> PlayerOnPlatform = delegate { };

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("MovePlatform"))
        {
            transform.SetParent(collision.transform);
            //PlayerOnPlatform?.Invoke(true, collision.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("MovePlatform"))
        {
            //PlayerOnPlatform?.Invoke(false, null);
        }
    }

}
