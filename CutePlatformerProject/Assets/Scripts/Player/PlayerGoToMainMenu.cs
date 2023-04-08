using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoToMainMenu : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LoadLevel"))
        {
            StartCoroutine(LoadingMainMenu());
        }
    }

    private IEnumerator LoadingMainMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
