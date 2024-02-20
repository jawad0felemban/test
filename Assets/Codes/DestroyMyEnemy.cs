using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics.Tracing;

public class DestroyMyEnemy : MonoBehaviour
{
    private Rigidbody m_VsObject;
    private Pausebutton m_Text;
    private MyKillScore m_MyKillCounter;

    void Start()
    {
        m_VsObject = GetComponent<Rigidbody>();
        m_MyKillCounter = FindAnyObjectByType<MyKillScore>();

    }

  
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            m_MyKillCounter.IncreaseCounter();
            Destroy(gameObject);
        }     
        if (collision.gameObject.tag == "PlayerWeapons")
        {
            Destroy(gameObject);
        }
        
           
               
    }
}
