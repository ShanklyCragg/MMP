using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtificialGravity : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    private void FixedUpdate()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }
}