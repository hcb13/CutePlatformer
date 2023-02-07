using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                panelLoadingLevel.SetActive(true);
            }
        }
    }

    //private IEnumerator FinishLevel()
    //{
    //    yield return new WaitForSecondsRealtime(1f);

    //    levelLoader.NextLevel = idMapScene;
    //    levelLoader.OnNextLevel();

    //}
}
