using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chameleon : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;


    private void Start()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
       InvokeRepeating("RandomColor", 0f, .5f);
    }


    public void RandomColor()
    {
        int colorIndex = Random.Range(0, 4);
        print(colorIndex);

        switch (colorIndex)
        {
            case 0:
                _spriteRenderer.material.color = Color.cyan;
                break;
            case 1:
                _spriteRenderer.material.color = Color.magenta;
                break;
            case 2:
                _spriteRenderer.material.color = new Color(140f / 255f, 19f / 255f, 251f / 255f);       // Since referencing color is not working?
                break;
            case 3:
                _spriteRenderer.material.color = Color.yellow;
                break;
        }
    }
}
