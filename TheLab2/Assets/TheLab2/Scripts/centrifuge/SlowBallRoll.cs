using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBallRoll : MonoBehaviour {

    public Rigidbody rb;
    private float scaler = 0.1f;
 
    void Start()
    {
        rb.sleepThreshold = 0.01f;
    }

    void FixedUpdate()
    {
        Debug.Log(rb.angularVelocity.x + " : " + rb.angularVelocity.y + " : " + rb.angularVelocity.z);
        rb.inertiaTensorRotation = new Quaternion(0.1f, 0.1f, 0.1f, 1);
        rb.AddTorque(-rb.angularVelocity * scaler);
    }
}