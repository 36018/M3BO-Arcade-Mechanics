using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 750f;
    public float rotationspeed = 120f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { //poppetje vooruit bewegen
          rb.AddForce(transform.forward * speed * Time.deltaTime);

            //transform.Translate(transform.forward *speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed * Time.deltaTime);
            //transform.Translate(transform.back * speed);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = Vector3.zero;
        }
        
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = Vector3.zero;
        }

        float xMove = Input.GetAxis("Horizontal");

        rb.transform.Rotate(transform.up, rotationspeed * xMove * Time.deltaTime);


    }
}
