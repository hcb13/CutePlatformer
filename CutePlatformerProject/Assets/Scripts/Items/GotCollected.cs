using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GotCollected : MonoBehaviour
{
    private static int amountCollected = 0;

    private void Start()
    {
        amountCollected = 0;
        UpdateTextFruitsCollected();
    }

    public void OnGotCollected()
    {
        amountCollected++;
        UpdateTextFruitsCollected();

        gameObject.SetActive(false);
    }

    private void UpdateTextFruitsCollected()
    {
        GameObject textFruitsCollected = GameObject.Find("TextFruitsCollected");
        if (textFruitsCollected != null)
            textFruitsCollected.GetComponent<TextMeshProUGUI>().text = amountCollected.ToString();
    }
}
