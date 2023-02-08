using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float fallDelay = 1f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float destroyDelay = 2f;

    private Vector3 initialPosition;
    private bool fall = false;

    private Rigidbody2D rb;

    private void Awake()
    {
        initialPosition = transform.position;
        fall = false;

        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private void Update()
    {
        if (fall)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            if (transform.position.y >= initialPosition.y)
            {
                transform.position = initialPosition;
                fall = false;
            }
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        
        yield return new WaitForSeconds(destroyDelay);
        rb.bodyType = RigidbodyType2D.Static;
        rb.bodyType = RigidbodyType2D.Kinematic;
        fall = true;
    }

   
}
