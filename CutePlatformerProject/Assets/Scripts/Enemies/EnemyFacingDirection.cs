using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacingDirection : MonoBehaviour
{
    public Action<bool> OnFacingRight = delegate { };

    [SerializeField]
    private bool _facingRight = false;
    public bool FacingRight
    {
        get { return _facingRight;  }
    }


    public void Flip()
    {
        _facingRight = !_facingRight;
        float localScaleX = transform.localScale.x;
        localScaleX = localScaleX * -1f;
        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);

        OnFacingRight?.Invoke(_facingRight);
    }
}
