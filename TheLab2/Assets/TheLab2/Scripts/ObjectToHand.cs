﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ObjectToHand : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
		
//	}
	
//	// Update is called once per frame
//	void FixedUpdate () {

//        //var current = this.GetComponent<Rigidbody>().angularVelocity.magnitude;
//        //Debug.Log(current);

//        if (Input.GetAxis("openvr-r-grip-press") >0.1 || Input.GetAxis("openvr-l-grip-press") > 0.1)
//        {
//            var controller = GameObject.FindGameObjectsWithTag("RightController");

//            this.transform.rotation = Quaternion.Euler(0,180,0);

//            this.transform.position = controller[0].transform.position + new Vector3(0, 0, 0.9f);
//            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
//            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

//        }

//    }
//}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectToHand : MonoBehaviour
{

    private UnityAction someListener;

    private void Awake()
    {
        someListener = new UnityAction(ObjectIntoHand);
    }

    private void OnEnable()
    {
        EventManager.StartListening("ObjectIntoHand", someListener);
    }

    //need to stop listening on disable to avoid memory leaks
    private void OnDisable()
    {
        EventManager.StopListening("ObjectIntoHand", someListener);
    }

    void ObjectIntoHand()
    {
        var controller = GameObject.FindGameObjectsWithTag("RightController");

        this.transform.rotation = Quaternion.Euler(0, 180, 0);

        this.transform.position = controller[0].transform.position + new Vector3(0, 0, 0.9f);
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

}
