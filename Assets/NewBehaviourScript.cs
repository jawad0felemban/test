using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float m_speed;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position += Vector3.forward * m_speed * Time.deltaTime;
        transform.position += Vector3.back * m_speed * Time.deltaTime;
        transform.position += Vector3.right * m_speed * Time.deltaTime;
        transform.position += Vector3.left * m_speed * Time.deltaTime;
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
    }
}
