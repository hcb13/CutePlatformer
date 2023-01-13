using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject key;

    private string keyName;

    private bool isOpen = false;

    public Action OnOpenDoor = delegate { };

    private void Awake()
    {
        key.GetComponent<SetInventory>().OnGotItem += GotKeyOpenDoor;
        keyName = key.GetComponent<SetInventory>().NameItem;
    }

    private void GotKeyOpenDoor(string itemName)
    {
        if(string.Equals(itemName, keyName))
        {
            isOpen = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isOpen)
            {
                key.GetComponent<SetInventory>().GetItemFromInventory();
                OnOpenDoor?.Invoke();
            }
        }
    }

}
