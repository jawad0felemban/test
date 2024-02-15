using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class BulletsControl : MonoBehaviour
{
    private Rigidbody m_BC;
    private void Awake()
    {
        m_BC = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        m_BC.velocity += Vector3.forward;
        Destroy(gameObject,1.0f);

    }
}
