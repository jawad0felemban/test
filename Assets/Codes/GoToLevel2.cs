using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel2 : MonoBehaviour
{
    public void GotoLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
}