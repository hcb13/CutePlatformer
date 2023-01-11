using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckGround : MonoBehaviour
{
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private float groundCheckRadius;

    public Action<bool> OnGetIsGrounded = delegate { };

    private bool _isGrounded;

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        OnGetIsGrounded?.Invoke(_isGrounded);
    }

}
