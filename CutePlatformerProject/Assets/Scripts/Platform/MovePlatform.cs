using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
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
    private float horizontal = 1;
    [SerializeField]
    private float vertical = 0;

    private bool isMoving = true;

    private Rigidbody2D _rigidbody;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isMoving)
        {
            if (Vector2.Distance(transform.position, _waypoints[target].position) <= distanceOfWaypoints)
            {
                
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

            horizontal *= -1;
            vertical *= -1;

        }        

        _rigidbody.velocity = new Vector2(horizontal * _speed, vertical * _speed);
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
