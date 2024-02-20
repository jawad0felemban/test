using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Pausebutton : MonoBehaviour
{
    public bool IsPauased;
    public void PuaseGame()
    {
        IsPauased = true;
        Time.timeScale = 0.0f;
    }
    public void Resume()
    {
        IsPauased = false;
        Time.timeScale = 1.0f;
    }
}