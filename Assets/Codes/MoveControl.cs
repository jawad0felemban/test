using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Color = System.Drawing.Color;

public class MoveControl : MonoBehaviour
{
    [SerializeField] float m_speed;
    private Rigidbody m_Player;
    

    public void Awake()
    {
        m_Player = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        
        
    }

    //private float q = 0.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            m_Player.velocity = Vector3.forward * m_speed;
        if (Input.GetKey(KeyCode.S))
            m_Player.velocity = Vector3.back * m_speed;
        if (Input.GetKey(KeyCode.D))
            m_Player.velocity = Vector3.right * m_speed;
        if (Input.GetKey(KeyCode.A))
            m_Player.velocity = Vector3.left * m_speed;
        if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < 11; i++)
            {
                m_Player.velocity = Vector3.up ;
            }
        }

        //q += Time.deltaTime * 50;
        //Debug.DrawLine(Vector3.zero, new Vector3(q, 2, 2), UnityEngine.Color.red);

        //Debug.DrawLine(Vector3.zero, new Vector3(q, q, q), UnityEngine.Color.blue);
    }
}

