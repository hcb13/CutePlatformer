using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Recorder.OutputPath;

public class EnemyMove : MonoBehaviour
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

    private bool isMoving = true;

    private EnemyFacingDirection _direction;
    private Rigidbody2D _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _direction = GetComponent<EnemyFacingDirection>();
    }

    private void Update()
    {
        if (isMoving)
        {
            if (Vector2.Distance(transform.position, _waypoints[target].position) <= distanceOfWaypoints)
            {
                StartCoroutine(Wait());
            }
        }
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, _waypoints[target].position) <= distanceOfWaypoints)
        {
            if (target == _waypoints.Count - 1)
            {
                target = 0;
            }
            else
            {
                target += 1;
            }
            _direction.Flip();
        }

        if (isMoving)
        {
            float horizontalVelocity = _speed * -1f;

            if (_direction.FacingRight)
            {
                horizontalVelocity *= -1f;
            }

            _rigidbody.velocity = new Vector2(horizontalVelocity,
                                              _rigidbody.velocity.y);
        }
    }

    private IEnumerator Wait()
    {
        StopMove();
        yield return new WaitForSecondsRealtime(waitTime);
        isMoving = true;
    }

    private void StopMove()
    {
        isMoving = false;
        _rigidbody.velocity = Vector2.zero;
    }

}
