using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField]
    private LevelLoader levelLoader;

    public Action OnPlay = delegate { };

    [SerializeField]
    private int idMapScene;

    private void Awake()
    {
        levelLoader.NextLevel = idMapScene;
        OnPlay += levelLoader.OnNextLevel;
    }

    public void Play()
    {
        OnPlay?.Invoke();
    }

}
