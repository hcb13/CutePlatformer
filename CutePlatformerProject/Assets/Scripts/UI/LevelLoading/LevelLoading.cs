using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoading : MonoBehaviour
{

    [SerializeField]
    private List<RectTransform> player;

    [SerializeField]
    private int idCurrentPlayerTag = 0;

    [SerializeField]
    private int idNextPlayerTag = 1;

    [SerializeField]
    private float speedMovement = 10f;

    [SerializeField]
    private LevelLoader levelLoader;

    private void Update()
    {
        if (player[idCurrentPlayerTag].position.x < player[idNextPlayerTag].position.x)
        {
            Vector3 auxPos = player[idCurrentPlayerTag].position;
            auxPos.y = auxPos.z = 0;
            auxPos.x = speedMovement * Time.deltaTime;
            player[idCurrentPlayerTag].position += auxPos;
        }
        else
        {
            levelLoader.NextLevel = idNextPlayerTag + 1;
            levelLoader.OnNextLevel();
        }

    }

}
