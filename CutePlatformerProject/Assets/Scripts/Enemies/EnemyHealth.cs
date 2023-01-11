using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   public void AddDamage()
    {
        Debug.Log("Damage");
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
