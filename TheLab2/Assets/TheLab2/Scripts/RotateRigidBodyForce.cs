using UnityEngine;
using System.Collections;

public class RotateRigidBodyForce : MonoBehaviour
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
        rb.AddTorque(transform.up * torque);
    }
}