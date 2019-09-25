using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Player _player;

    void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if(_player == null) { return; }

        Vector3 playerPos = _player.transform.position;

        if(playerPos.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        }

    }
}
