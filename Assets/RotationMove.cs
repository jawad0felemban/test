using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMove : MonoBehaviour
{
    [SerializeField] private Transform m_Raaiontotransform;

    public void Awake()
    {
        
    }

    void Start()
    {

    }



    private void Update()
    {
        Debug.DrawLine(transform.position , m_Raaiontotransform.position , Color.green);

    }
}
