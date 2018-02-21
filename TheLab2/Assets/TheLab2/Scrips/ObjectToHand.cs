using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToHand : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("openvr-r-grip-press") >0.1 || Input.GetAxis("openvr-l-grip-press") > 0.1)
        {
            var controller = GameObject.FindGameObjectsWithTag("RightController");
            this.transform.position = controller[0].transform.position;
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

    }
}
