using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShorterGun : MonoBehaviour
{
    [SerializeField] private GameObject m_bulletstY;
    [SerializeField] private GameObject m_bulletstR;
    [SerializeField] private GameObject m_bulletstB;

    private Rigidbody m_bullets;


    private void Awake()
    {
        //InvokeRepeating("KeepFire", 2.0f, 1.0f);
        //InvokeRepeating("StopFire", 2.0f, 1.0f);
        m_bullets = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(m_bulletstY, m_bullets.velocity, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(m_bulletstR, m_bullets.velocity, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Instantiate(m_bulletstB, m_bullets.velocity, Quaternion.identity);
        }
    }

}


