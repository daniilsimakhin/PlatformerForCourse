﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _jumpSpeed;
    private Animator _animator;
    private Rigidbody2D _rigibody;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigibody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * _horizontalSpeed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;
            _animator.SetFloat("Speed", 1 * _horizontalSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * _horizontalSpeed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false;
            _animator.SetFloat("Speed", 1 * _horizontalSpeed * Time.deltaTime);
        }
        else
        {
            _animator.SetFloat("Speed", 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 1f), transform.up);
            if (hit.collider != null)
            {
                if (hit.collider.name == "Tilemap")
                {
                    _rigibody.AddForce(Vector2.up * _jumpSpeed);
                }
            }
        }
    }

}
