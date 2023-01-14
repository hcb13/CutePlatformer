using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel : MonoBehaviour
{
    [SerializeField]
    private int idInititalLevel = 0;

    [SerializeField]
    private int idLastLevel = 1;

    [SerializeField]
    private GameObject door;

    private bool canGoNextLevel = false;

    private void Awake()
    {
        GetComponent<GetInput>().OnGetButtonInteract += NextLevel;
        door.GetComponent<OpenDoor>().OnOpenDoor += CanGoNextLevel;
    }

    private void CanGoNextLevel()
    {
        canGoNextLevel = true;
    }

    private void NextLevel(bool buttonDown)
    {
        if (buttonDown && canGoNextLevel)
        {
            StartCoroutine(LoadNextLevel());
        }
    }

    private IEnumerator LoadNextLevel()
    {
        if (idInititalLevel + 1 <= idLastLevel) {
            if(!SceneManager.GetSceneByBuildIndex(idInititalLevel + 1).isLoaded)
            {
                //var loadScene = SceneManager.LoadSceneAsync(idInititalLevel + 1, LoadSceneMode.Additive);
                var loadScene = SceneManager.LoadSceneAsync(idInititalLevel + 1);

                while (!loadScene.isDone)
                {
                    yield return null;
                }
            }
        }

    }
}
