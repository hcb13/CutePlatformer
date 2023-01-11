using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInput : MonoBehaviour
{
    public Action<float> OnGetHorizontalAxis = delegate { };
    public Action<bool> OnGetButtonDownJump = delegate { };
    public Action<bool> OnGetButtonDownAttack = delegate { };

    public void Update()
    {
        OnGetHorizontalAxis?.Invoke(Input.GetAxisRaw("Horizontal"));
        OnGetButtonDownJump?.Invoke(Input.GetButtonDown("Jump"));
        OnGetButtonDownAttack?.Invoke(Input.GetButtonDown("Attack"));
    }
}
