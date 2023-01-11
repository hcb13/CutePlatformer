using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 2.5f;

    private bool _isGrounded = true;

    private Rigidbody2D _rigibody;

    public Action<bool> OnSetIsGrounded = delegate { };
    public Action<float> OnGetVerticalVelocity = delegate { };
    public Action OnIsJumpingTrue = delegate { };
    public Action OnIsJumpingFalse = delegate { };

    private void Awake()
    {
        GetComponent<PlayerCheckGround>().OnGetIsGrounded += SetIsGrounded;
        GetComponent<GetInput>().OnGetButtonDownJump += Jump;

        _rigibody = GetComponent<Rigidbody2D>();
    }

    private void SetIsGrounded(bool isGrounded)
    {
        _isGrounded = isGrounded;
    }

    private void Jump(bool buttonDown)
    {        
        if (buttonDown && _isGrounded)
        {
            _rigibody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void LateUpdate()
    {
        OnSetIsGrounded?.Invoke(_isGrounded);
        OnGetVerticalVelocity?.Invoke(_rigibody.velocity.y);
    }
}
