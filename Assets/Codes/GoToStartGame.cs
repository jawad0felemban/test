using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButtontoChageLevel : MonoBehaviour
{
    public void GotoStartGame()
    {
        SceneManager.LoadScene("StartGame");
    }
}