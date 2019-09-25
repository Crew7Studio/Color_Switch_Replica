using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidBody;
    private SpriteRenderer _spriteRenderer;
    private Color _currentColor;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            _rigidBody.velocity = Vector2.up * _jumpForce;
        }
    }
}
