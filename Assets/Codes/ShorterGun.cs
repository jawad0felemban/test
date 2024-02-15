using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShorterGun : MonoBehaviour
{
    [SerializeField] private GameObject m_bulletstY;
    [SerializeField] private GameObject m_bulletstR;
    [SerializeField] private GameObject m_bulletstB;
    [SerializeField] private float m_FireRateOfShoting;
    

    private Rigidbody m_bullets;


    private void Awake()
    {

        m_bullets = GetComponent<Rigidbody>();
    }
    
    void Start()
    {

    }

    
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("ShootY", 0.5f,m_FireRateOfShoting);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            InvokeRepeating("ShootR", 0.5f, m_FireRateOfShoting);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            InvokeRepeating("ShootB", 0.5f, m_FireRateOfShoting);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            CancelInvoke();
        }
        //if (Input.GetKey(KeyCode.Space))
        //{
        //     Instantiate(m_bulletstY, transform.position, Quaternion.identity);

        //    //Instantiate(m_bulletstY, transform.position , Quaternion.identity);
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    Instantiate(m_bulletstR, transform.position, Quaternion.identity);

        //    //Instantiate(m_bulletstR, transform.position , Quaternion.identity);
        //}
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    Instantiate(m_bulletstB, transform.position, Quaternion.identity);

        //    //Instantiate(m_bulletstB, transform.position , Quaternion.identity);
        //}

    }
    private void ShootY()
    {
                    Instantiate(m_bulletstY, transform.position, Quaternion.identity);
    }
    private void ShootR()
    {
        Instantiate(m_bulletstR, transform.position, Quaternion.identity);
    }
    private void ShootB()
    {
        Instantiate(m_bulletstB, transform.position, Quaternion.identity);
    }

}


