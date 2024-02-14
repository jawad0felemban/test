using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShorterGun : MonoBehaviour
{
    [SerializeField] private GameObject m_bulletst;
    private void Awake()
    {
        //InvokeRepeating("KeepFire", 2.0f, 1.0f);
        //InvokeRepeating("StopFire", 2.0f, 1.0f);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(m_bulletst, transform.position, Quaternion.identity);
        }
    }

}


