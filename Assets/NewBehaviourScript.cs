using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public int m_speed;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position += Vector3.forward * m_speed;
        transform.position += Vector3.back * m_speed;
        transform.position += Vector3.right * m_speed;
        transform.position += Vector3.left * m_speed;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.W))
            transform.position += Vector3.forward * m_speed * Time.deltaTime; ;
        if (Input.GetKeyUp(KeyCode.S))
            transform.position += Vector3.back;
        if (Input.GetKeyUp(KeyCode.D))
            transform.position += Vector3.right;
        if (Input.GetKeyUp(KeyCode.A))
            transform.position += Vector3.left;
    }
}
