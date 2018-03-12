using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.up * 1);
    }
}
