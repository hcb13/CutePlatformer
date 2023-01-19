using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoNextLevel : MonoBehaviour
{

    [SerializeField]
    private LevelLoader levelLoader;

    [SerializeField]
    private int idMapScene = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LoadLevel"))
        {
            StartCoroutine(FinishLevel());            
        }
    }

    private IEnumerator FinishLevel()
    {
        yield return new WaitForSecondsRealtime(1f);

        levelLoader.NextLevel = idMapScene;
        levelLoader.OnNextLevel();

    }
}
