using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


public class animation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float xForce = 20.0f;
    public float yForce = 20.0f;
    public float zForce = 20.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x = x - xForce;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += xForce;
        }
        if (Input.GetKey(KeyCode.W))
        {
            z += zForce;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = z - zForce;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            y = yForce;
        }
        GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
