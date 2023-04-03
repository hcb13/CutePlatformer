using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoNextLevel : MonoBehaviour
{

    [SerializeField]
    private GameObject panelLoadingLevel;

    [SerializeField] private int nextLevel = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LoadLevel"))
        {            
            if (nextLevel != 0)
            {
                panelLoadingLevel.SetActive(true);
                StartCoroutine(LoadingLevel());
            }
            else
            {
                StartCoroutine(GoToMainMenu());
            }
        }
    }

    private IEnumerator LoadingLevel()
    {
        yield return new WaitForSeconds(2f);
        panelLoadingLevel.SetActive(true);
    }

    private IEnumerator GoToMainMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
