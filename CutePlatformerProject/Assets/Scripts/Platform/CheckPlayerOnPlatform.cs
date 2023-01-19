using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerOnPlatform : MonoBehaviour
{

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("MovePlatform"))
        {
            transform.SetParent(collision.transform);
            transform.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("MovePlatform"))
        {
            transform.SetParent(null);
            transform.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }

}
