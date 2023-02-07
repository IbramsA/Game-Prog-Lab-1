using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float speed = 5;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(new Vector3(-1, 0, 0) * speed);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.AddForce(new Vector3(0, 0, 1) * speed);
        }
        else if(Input.GetKey(KeyCode.A)){
            rb.AddForce(new Vector3(0, 0, -1) * speed);
        }
        else if(Input.GetKey(KeyCode.S)){
            rb.AddForce(new Vector3(1, 0, 0) * speed);
        }
    }
}
