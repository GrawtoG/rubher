﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject optionMenuUI;
    public GameObject scoreUI;


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }

    public void QuitPauseMenu()
    {
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
        Debug.Log("Welcome");
    }

    public void OptiondOn()
    {
        pauseMenuUI.SetActive(false);
        optionMenuUI.SetActive(true);
        scoreUI.SetActive(false);

    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        scoreUI.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        

    }

   
}
