using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MyKillScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m__Text;
    private int m_MyCounter;    
    
    public void IncreaseCounter() 
    {  
        ++m_MyCounter;
        m__Text.text = m_MyCounter.ToString();
    }
        
    }
    

