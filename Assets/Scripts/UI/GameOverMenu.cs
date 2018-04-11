﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour 
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}