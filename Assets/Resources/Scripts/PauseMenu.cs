using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    private void Start()
    {
        CD_BeforeResumeGame.Instance.SrartCountDownSooooka();
    }

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

    public void Resume()
    {
       pauseMenuUI.SetActive(false);
       CD_BeforeResumeGame.Instance.CountDown(5);
       GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
        Resume();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
