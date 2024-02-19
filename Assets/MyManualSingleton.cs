using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyManualSingleton : MonoBehaviour
{
    public static MyManualSingleton instance;

    private void Awake()
    {
        if (instance != null)
            Debug.LogError($"Duplicate singleton!");
        instance = this;
    }
    private void OnDestroy()
    {
        instance = null;
    }
}
