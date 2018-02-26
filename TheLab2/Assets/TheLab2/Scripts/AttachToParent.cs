using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision Collided)
    {
        //if (Collided.gameObject.tag == "Cylinder")
        //{
            //this.transform.SetParent(Collided.gameObject.transform);
        //}
    }
}
