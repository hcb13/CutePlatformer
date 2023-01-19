using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    private float transitionTime = 1f;

    private Animator _animator;

    [SerializeField]
    private int nextLevel;
    public int NextLevel
    {
        get { return nextLevel; }
        set { nextLevel = value; }
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnNextLevel()
    {
        StartCoroutine(StartTransition());
        StartCoroutine(LoadNextLevel());
    }

    private IEnumerator StartTransition()
    {
        _animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);        
    }

    private IEnumerator LoadNextLevel()
    {
        if (!SceneManager.GetSceneByBuildIndex(nextLevel).isLoaded)
        {
            var loadScene = SceneManager.LoadSceneAsync(nextLevel);

            while (!loadScene.isDone)
            {
                yield return null;
            }
        }
    }

}
