using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoFire : MonoBehaviour
{
    [SerializeField] private GameObject m_bulletstCG;
    [SerializeField] private GameObject m_bulletstCB;
    [SerializeField] private GameObject m_bulletstCX;
    [SerializeField] private float m_FireRateOfShoting;

    private Pausebutton m_PauseButton;
    private Rigidbody m_bulletsE;


    private void Awake()
    {
        m_PauseButton = FindAnyObjectByType<Pausebutton>();
        m_bulletsE = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }


    private void Update()
    {
        if (!m_PauseButton.IsPauased) 
        { 

        InvokeRepeating("ShootB", 0.10f, m_FireRateOfShoting);
        //for (int i = 0; i == 4; i++)
        //{
        //    if (i == 0)
        //    {
        //        InvokeRepeating("ShootB", 0.5f, m_FireRateOfShoting);
        //    }
        //    if (i == 1)
        //    {
        //        InvokeRepeating("ShootG", 0.5f, m_FireRateOfShoting);
        //    }
        //    if (i == 2)
        //    {
        //        InvokeRepeating("ShootX", 0.5f, m_FireRateOfShoting);
        //    }
        //    else
        //        i = 0;
        //}
        }
    }

    private void ShootB()
    {
        Instantiate(m_bulletstCB, transform.position, Quaternion.identity);
    }
    private void ShootG()
    {
        Instantiate(m_bulletstCG, transform.position, Quaternion.identity);
    }
    private void ShootX()
    {
        Instantiate(m_bulletstCX, transform.position, Quaternion.identity);
    }
}
