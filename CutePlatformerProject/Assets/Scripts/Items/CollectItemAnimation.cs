using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabCollectAnimation;


    public void ShowCollectAnimation()
    {
        GameObject _gameObject = Instantiate(prefabCollectAnimation, transform.position, Quaternion.identity);
        Destroy(_gameObject, 1f);
    }
}
