using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    [Header("Colors")]
    [SerializeField] private Color _cyan;
    [SerializeField] private Color _magenta;
    [SerializeField] private Color _purple;
    [SerializeField] private Color _yellow;


    private Rigidbody2D _rigidBody;
    private SpriteRenderer _spriteRenderer;
    private string _currentColor;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        SetRandomColor();
    }



    void Update()
    {
        Movement();

        if(transform.position.y < Camera.main.transform.position.y - 10f)
        {
            GameManager.Instance.ReloadLevel();
        }
    }


    private void Movement()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            _rigidBody.velocity = Vector2.up * _jumpForce;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == _currentColor) {
            print("same color");
        }
        else if (other.tag == "RandomColorChanger")
        {
            SetRandomColor();
            Destroy(other.gameObject);
        }
        else
        {
            GameManager.Instance.ReloadLevel();
        }
    }



    private void SetRandomColor()
    {
        int colorIndex = Random.Range(0, 4);

        switch (colorIndex)
        {
            case 0:
                _currentColor = "Cyan";
                _spriteRenderer.material.color = _cyan;
                break;
            case 1:
                _currentColor ="Magenta";
                _spriteRenderer.material.color = _magenta;
                break;
            case 2:
                _currentColor ="Purple";
                _spriteRenderer.material.color = _purple;
                break;
            case 3:
                _currentColor ="Yellow";
                _spriteRenderer.material.color = _yellow;
                break;
        }
    }

    
}
