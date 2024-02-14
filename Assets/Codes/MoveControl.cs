using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class MoveControl : MonoBehaviour
{
    [SerializeField] float m_speed;
    
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.forward * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * m_speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < 5; i++)
            {
                transform.position += Vector3.down;
            }
        }
            
        if (Input.GetKeyDown(KeyCode.V))
        {
            for (int i = 0; i < 5; i++)
            {
                transform.position += Vector3.up;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
            transform.position = Vector3.zero * m_speed * Time.deltaTime;
    }
}

