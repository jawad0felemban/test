using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shortgun : MonoBehaviour
{
    [SerializeField] private GameObject m_bullt;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(m_bullt);
        }
    }
}
