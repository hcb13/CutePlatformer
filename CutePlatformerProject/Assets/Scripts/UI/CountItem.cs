using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountItem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textItem;

    [SerializeField]
    private string nameItem;

    private int amount = 0;

    private void Awake()
    {
        GetComponent<GotCollected>().OnCollected += Count;
    }

    private void Count(string item)
    {
        if(string.Equals(nameItem, item))
        {
            amount++;
            textItem.text = amount.ToString();
        }
    }
}
