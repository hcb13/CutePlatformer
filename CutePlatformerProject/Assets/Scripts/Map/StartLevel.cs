using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StartLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject panelStartLevel;

    [SerializeField]
    private TMPro.TextMeshProUGUI textLevelName;
    private string auxText;

    [SerializeField]
    private LevelLoader levelLoader;

    private int nextLevel;

    private void Awake()
    {
        panelStartLevel.SetActive(false);
        auxText = textLevelName.text;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Level"))
        {
            panelStartLevel.SetActive(true);
            textLevelName.text += " " + collision.name;
            nextLevel = Int32.Parse(collision.name.Remove(0, 6));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Level"))
        {
            panelStartLevel.SetActive(false);
            textLevelName.text = auxText;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            levelLoader.NextLevel = nextLevel;
            levelLoader.OnNextLevel();
        }
    }

}
