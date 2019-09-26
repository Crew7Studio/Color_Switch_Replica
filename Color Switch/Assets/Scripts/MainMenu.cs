using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string _levelToLoad;

    private void OnEnable()
    {
       // Screen.SetResolution(480, 720, false);
    }

    public void Play()
    {
        SceneManager.LoadScene(_levelToLoad);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
