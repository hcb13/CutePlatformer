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
            if (panelLoadingLevel != null)
            {
                StartCoroutine(LoadingLevel());
            }
        }
    }

    private IEnumerator LoadingLevel()
    {
        yield return new WaitForSeconds(2f);
        panelLoadingLevel.SetActive(true);
    }

}
