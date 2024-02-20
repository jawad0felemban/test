using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel1 : MonoBehaviour
{
    public void GotoLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

}
