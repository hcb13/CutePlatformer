using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotCollected : MonoBehaviour
{
    public void OnGotCollected()
    {
        gameObject.SetActive(false);
    }
}
