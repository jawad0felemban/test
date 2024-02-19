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
    
    
    void Start()
    {
        m_VsObject = GetComponent<Rigidbody>();
        //m_Text = FindAnyObjectByType<TextMeshProUGUI>();

    }

  
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.tag != "PlayerWeapons")
                Destroy(gameObject);
        }
    }
}
