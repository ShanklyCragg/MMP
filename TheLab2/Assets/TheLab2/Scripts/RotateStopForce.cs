using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStopForce : MonoBehaviour
{
    public float torque;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //Follows "left hand rule", with "up" donating direction of thumb
        rb.AddTorque(-transform.up * torque);
    }
}