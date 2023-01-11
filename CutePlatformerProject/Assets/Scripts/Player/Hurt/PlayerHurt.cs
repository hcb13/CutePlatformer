using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour
{
    [SerializeField]
    private float force = 2f;

    private Rigidbody2D _rigidbody;

    public Action OnGetHurt = delegate { };
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        GetComponent<CheckPlayerGetHurt>().OnGetHurt += GotHurt;
    }

    private void GotHurt()
    {
        _rigidbody.AddForce( Vector2.up * force, ForceMode2D.Impulse);
        OnGetHurt?.Invoke();
    }

}
