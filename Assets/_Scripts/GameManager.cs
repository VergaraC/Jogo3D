using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;
    public static int cubos;
    public GameObject startUI;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        //ChangeState(GameState.TitleMenu);
    }

    public void ChangeState(GameState newState)
    {
        GameState = newState;
        switch (newState)
        {
            case GameState.TitleMenu:   
                if (MenuController.GameIsStarting)
                {
                    startUI.SetActive(true);
                }
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("Menu");
                break;
            case GameState.Level1:
                SceneManager.LoadScene("Level1");
                cubos = 50;
                break;
            case GameState.Level2:
                SceneManager.LoadScene("Level2");
                cubos = 1;
                break;
            case GameState.Level3:
                SceneManager.LoadScene("Level3");
                cubos = 1;
                break;
            case GameState.Tutorial:
                SceneManager.LoadScene("Tutorial");
                cubos = 1000;
                break;
            case GameState.Sandbox:
                SceneManager.LoadScene("Sandbox");
                cubos = 1000000000;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}

public enum GameState
{
    TitleMenu = 0,
    Level1 = 1,
    Level2 = 2,
    Level3 = 3,
    Tutorial = 4,
    Sandbox = 5
}