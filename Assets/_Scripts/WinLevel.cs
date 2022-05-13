using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    public GameObject winUI;
    public AudioSource audioSource;

    public void OnTriggerEnter(Collider collision)
    {  
        audioSource.Play();
        Pause();
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
