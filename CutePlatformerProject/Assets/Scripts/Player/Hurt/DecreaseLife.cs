using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecreaseLife : MonoBehaviour
{
    [SerializeField] private GameObject life1;
    [SerializeField] private GameObject life2;
    [SerializeField] private GameObject life3;

    private int lifeAmount = 3;

    private void Start()
    {
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
    }

    public void LostLife()
    {
        lifeAmount--;
        SetLifesActive();
    }

    private void SetLifesActive()
    {
        switch(lifeAmount)
        {
            case 2:
                life3.SetActive(false);
                break;
            case 1:
                life2.SetActive(false);
                break;
            case 0:
                life1.SetActive(false);
                break;
            case -1:
                SceneManager.LoadScene(0);
                break;
        }
    }
}
