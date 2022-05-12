using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.Instance.ChangeState(GameState.Level1);
    }

    public void OnClick2()
    {
        GameManager.Instance.ChangeState(GameState.Level2);
    }

    public void OnClick3()
    {
        GameManager.Instance.ChangeState(GameState.Level3);
    }

    public void OnClickTutorial()
    {
        GameManager.Instance.ChangeState(GameState.Tutorial);
    }

    public void OnClickSandbox()
    {
        GameManager.Instance.ChangeState(GameState.Sandbox);
    }

    public void OnClickMenu()
    {
        GameManager.Instance.ChangeState(GameState.TitleMenu);
    }
}
