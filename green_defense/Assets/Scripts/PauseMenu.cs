using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }


    void Update()
    {
        if(Input.GetButtonUp("Fire2")){
            if(GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }

        }
    
    }

    public void Resume()
    { 
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
