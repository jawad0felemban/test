using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoFire : MonoBehaviour
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
        for (int i = 0; i > 4; i++)
        {
            if (i == 0)
            {
                InvokeRepeating("ShootY", 0.5f, m_FireRateOfShoting);
            }
            if (i == 1)
            {
                InvokeRepeating("ShootY", 0.5f, m_FireRateOfShoting);
            }
            if (i == 2)
            {
                InvokeRepeating("ShootY", 0.5f, m_FireRateOfShoting);
            }
            else
                i = 0;

        }
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
