using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSaw : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _waypoints;

    [SerializeField]
    private int target;

    [SerializeField]
    private float waitTime = 3;

    [SerializeField]
    private float _speed = 2f;

    [SerializeField]
    private float distanceOfWaypoints = 0.1f;

    [SerializeField]
    private float distanceCurrent;

    private Rigidbody2D _rigidbody;

    float horizontalVelocity = 0f;
    float verticalVelocity = 0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        distanceCurrent = Vector2.Distance(transform.position, _waypoints[target].position);
        if (distanceCurrent <= distanceOfWaypoints)
        {
            if (target == _waypoints.Count - 1)
            {
                target = 0;
            }
            else
            {
                target += 1;
            }
        }

        horizontalVelocity = 0f;
        verticalVelocity = 0f;

        switch (target)
        {
            case 0:
                // going down
                verticalVelocity = _speed * -1f;
                break;
            case 1:
                // going right
                horizontalVelocity = _speed;
                break;
            case 2:
                verticalVelocity = _speed;
                // going up
                break;
            case 3:
                // going left
                horizontalVelocity = _speed * -1f; ;
                break;
        }

        _rigidbody.velocity = new Vector2(horizontalVelocity,
                                          verticalVelocity);
    }
}
