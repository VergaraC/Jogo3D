using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUi;
    public GameObject startUi;
    public static bool GameIsStarting = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void OnClick()
    {
        GameManager.Instance.ChangeState(GameState.Level1);
        Resume();
    }

    public void OnClick2()
    {
        GameManager.Instance.ChangeState(GameState.Level2);
        Resume();
    }

    public void OnClick3()
    {
        GameManager.Instance.ChangeState(GameState.Level3);
        Resume();
    }

    public void OnClickTutorial()
    {
        GameManager.Instance.ChangeState(GameState.Tutorial);
        Resume();
    }

    public void OnClickSandbox()
    {
        GameManager.Instance.ChangeState(GameState.Sandbox);
        Resume();
    }

    public void OnClickMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenuUi.SetActive(false);
        GameManager.Instance.ChangeState(GameState.TitleMenu);
    }

    public void OnClickStart()
    {
        GameIsStarting = false;
        startUi.SetActive(false);
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
