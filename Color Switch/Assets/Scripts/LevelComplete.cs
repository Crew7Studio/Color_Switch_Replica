using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private Text _points;
    [SerializeField] private string _nextLevel;
    [SerializeField] private string _mainMenu;

    private Player _player;
    private int _point;

    private void Start()
    {
        _player = FindObjectOfType<Player>();

        _point = _player.points;
        StartCoroutine(AnimateText());
    }

    public void Continue()
    {
        SceneManager.LoadScene(_nextLevel);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(_mainMenu);
    }

    IEnumerator AnimateText()
    {
        int count = 0;
        while(count <= _point)
        {
            _points.text = count.ToString();
            count++;
            yield return new WaitForSeconds(.05f);
        }
    }
}
