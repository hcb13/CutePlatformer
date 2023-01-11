using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerGetHurt : MonoBehaviour
{

    public Action OnGetHurt = delegate { };


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            OnGetHurt?.Invoke();
        }
    }

}
