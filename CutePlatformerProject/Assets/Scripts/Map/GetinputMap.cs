using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetinputMap : MonoBehaviour
{

    private float verticalMovement;
    private float horizontalMovement;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMovement = Input.GetAxisRaw("Vertical");
        horizontalMovement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
       _rigidbody.velocity = new Vector2(horizontalMovement, verticalMovement);
    }
}
