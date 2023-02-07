using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushPlayer : MonoBehaviour
{
    float push = 20;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter (Collision c)
    {
        if(c.collider.tag == "trap")
        {
            rb.AddForce(transform.forward * push);
        }
    }
}
