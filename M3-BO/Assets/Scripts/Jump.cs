using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springen : MonoBehaviour
{
    public float jumpHeight = 20f;
    public bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
            {
                rb.AddForce(Vector3.up * jumpHeight,ForceMode.Impulse);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
