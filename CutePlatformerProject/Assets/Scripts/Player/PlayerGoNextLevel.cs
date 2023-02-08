using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoNextLevel : MonoBehaviour
{

    [SerializeField]
    private GameObject panelLoadingLevel;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LoadLevel"))
        {
            if (panelLoadingLevel != null)
            {
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
