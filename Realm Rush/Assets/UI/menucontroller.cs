using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    [SerializeField] GameObject resume;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject quit;
    [SerializeField] GameObject panel;
    public bool GameIsPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        MainMenu.SetActive(false);
        panel.SetActive(false);
        resume.SetActive(false);
        quit.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused= false;
    }

    void Pause()
    {
        MainMenu.SetActive(true);
        panel.SetActive(true);
        resume.SetActive(true);
        quit.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1f;
    }

    public void ResumeGame()
    {
        MainMenu.SetActive(false);
        panel.SetActive(false);
        resume.SetActive(false);
        quit.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
