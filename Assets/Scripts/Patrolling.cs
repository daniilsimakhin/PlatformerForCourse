using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private Transform _pathToPoints;
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;

    private int _currentPosition;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        _points = new Transform[_pathToPoints.childCount];
        for (int i = 0; i < _pathToPoints.childCount; i++)
        {
            _points[i] = _pathToPoints.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPosition];

        if (transform.position.x - target.position.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            _animator.SetFloat("Speed", _speed * Time.deltaTime);
        }
        else if (transform.position.x - target.position.x > 0)
        {
            _animator.SetFloat("Speed", _speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            _animator.SetFloat("Speed", 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPosition++;
            if (_currentPosition == _points.Length)
            {
                _currentPosition = 0;
            }
        }
    }
}
