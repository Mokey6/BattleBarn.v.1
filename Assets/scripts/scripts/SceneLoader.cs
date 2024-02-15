using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private float initialTimeScale;

    void Start()
    {
        initialTimeScale = Time.timeScale;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = initialTimeScale;
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
