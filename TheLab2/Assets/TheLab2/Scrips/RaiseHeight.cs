using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseHeight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        this.transform.position += Vector3.up * Time.deltaTime;
    }
}
