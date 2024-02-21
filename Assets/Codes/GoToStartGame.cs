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
    public void GotoLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void GotoLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
}