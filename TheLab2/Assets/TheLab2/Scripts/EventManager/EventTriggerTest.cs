using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerTest : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("q"))
        {
            EventManager.TriggerEvent("test");
        }

        //Grip button on right controller
        if (Input.GetAxis("openvr-r-grip-press") > 0.1 || Input.GetAxis("openvr-l-grip-press") > 0.1)
        {
            EventManager.TriggerEvent("ObjectIntoHand");
        }
    }
}
