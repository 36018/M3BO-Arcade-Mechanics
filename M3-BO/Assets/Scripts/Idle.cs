using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{

    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("run");
            ani.SetTrigger("run");
            ani.ResetTrigger("idle");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("idle");
            ani.ResetTrigger("run");
            ani.SetTrigger("idle");
        }
    }
}
