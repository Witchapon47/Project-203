using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Debug.Log(this.name + "Inertia is :" + rb.inertiaTensor);

        rb.angularVelocity = rb.inertiaTensor;


    }
}
