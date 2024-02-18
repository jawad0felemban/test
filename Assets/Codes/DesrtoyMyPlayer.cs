using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesrtoyMyPlayer : MonoBehaviour
{
    private Rigidbody m_VsObject2;


    void Start()
    {
        m_VsObject2 = GetComponent<Rigidbody>();
    }


    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.tag != "EnemyWeapons")
                Debug.Log("You Get Hit By Enemy NoooooB!!!!!!!!!!!!!!!!!!!!!");
        }
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.tag != "EnemyWeapons")
                Destroy(gameObject);
        }
    }
}
