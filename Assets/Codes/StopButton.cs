using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Pausebutton : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu = null;

    bool isPaused;
    public bool GetIsPaused() { return isPaused; }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            pauseMenu.SetActive(isPaused);
        }
    }
}