using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMyEnemy : MonoBehaviour
{
    private Rigidbody m_VsObject;
    
    
    void Start()
    {
        m_VsObject = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerWeapons") 
        {
            if(collision.gameObject.tag != "Enemy")
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.tag != "PlayerWeapons")
                Destroy(gameObject);
        }
    }
}
