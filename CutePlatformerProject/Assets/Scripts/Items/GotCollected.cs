using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotCollected : MonoBehaviour
{
    [SerializeField]
    public List<string> items = new List<string>{"Strawberry",
                                                 "Melon",
                                                 "Key"};


    public Action<string> OnCollected = delegate { };

    public void OnGotCollected()
    {
        OnCollected?.Invoke(items[0]);
        gameObject.SetActive(false);
    }
}
