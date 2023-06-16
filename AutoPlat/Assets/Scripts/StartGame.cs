using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int gameStartScene;

    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(gameStartScene);
    }
}
