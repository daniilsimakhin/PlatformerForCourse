using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChase : MonoBehaviour
{
    [SerializeField] private Transform _characterTransform;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(_characterTransform.position.x, _characterTransform.position.y, -20), _speed);
    }
}
