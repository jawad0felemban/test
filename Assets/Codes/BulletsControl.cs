using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class BulletsControl : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_Bulletslifetime;
    private Rigidbody m_BC;
    private void Awake()
    {
        m_BC = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        
    }
    //
    private void Update()
    {
       // m_BC.velocity += Vector3.forward * m_Speed * Time.deltaTime;
       transform.position += Vector3.forward * m_Speed * Time.deltaTime;
        Destroy(gameObject, m_Bulletslifetime);

    }
}
