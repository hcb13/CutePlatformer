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

    [SerializeField]
    private GameObject textItem;

    public Action<string> OnCollected = delegate { };

    private void Awake()
    {
        CountItem _gameObject = textItem.GetComponent<CountItem>();
        if (_gameObject != null) {
            OnCollected += _gameObject.Count;
        }
    }


    public void OnGotCollected()
    {
        OnCollected?.Invoke(items[0]);
        gameObject.SetActive(false);
    }
}
