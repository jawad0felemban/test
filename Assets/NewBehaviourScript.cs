using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float m_speed;
    
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.forward * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
            transform.position += Vector3.up * m_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.C))
            transform.position += Vector3.down * m_speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E))
            transform.position = Vector3.zero * m_speed * Time.deltaTime;
    }
}

