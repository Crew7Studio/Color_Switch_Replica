using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed = 10;
    [SerializeField] private bool _clockwiseRotation = true;

    void Start()
    {
        
    }

    void Update()
    {
    
        if(_clockwiseRotation)
        {
            transform.Rotate(0f, 0f, -_rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0f, 0f, _rotationSpeed * Time.deltaTime);
        }
    }
}
