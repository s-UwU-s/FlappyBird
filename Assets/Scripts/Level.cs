using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void ReloadLevel()
    {
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(0);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
        LoadSettings();
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }
}
