﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Game"); //Вставити назву сцени тут !
    }

    public void ExitGame()
    {
        Debug.Log("Вихід з гри");
        Application.Quit();
    }
}