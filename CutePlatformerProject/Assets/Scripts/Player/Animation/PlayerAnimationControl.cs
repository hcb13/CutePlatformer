using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour
{

    private Animator _animator;

    private void Awake()
    {
        GetComponent<PlayerWalk>().OnSetIdle += UpdateAnimatorIdle;
        GetComponent<PlayerJump>().OnSetIsGrounded += UpdateAnimatorIsGrounded;
        GetComponent<PlayerJump>().OnGetVerticalVelocity += UpdateAnimatorVerticalVelocity;
        GetComponent<PlayerHurt>().OnGetHurt += UpdateAnimatorHurt;
        GetComponent<PlayerAttack>().OnAttack += UpdateAnimatorAttack;

        _animator = GetComponent<Animator>();
    }


    private void UpdateAnimatorIdle(bool isIdle)
    {
        _animator.SetBool("IsIdle", isIdle);
    }

    private void UpdateAnimatorIsGrounded(bool isGrounded)
    {
        _animator.SetBool("IsGrounded", isGrounded);
    }

    private void UpdateAnimatorVerticalVelocity(float verticalVelocity)
    {
        _animator.SetFloat("VerticalVelocity", verticalVelocity);
    }

    private void UpdateAnimatorHurt()
    {
        _animator.SetTrigger("Hurt");
    }

    private void UpdateAnimatorAttack()
    {
        _animator.SetTrigger("Attack");
    }
}
