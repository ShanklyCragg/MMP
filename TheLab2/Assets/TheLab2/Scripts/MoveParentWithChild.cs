using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParentWithChild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.parent.position = transform.position - transform.localPosition;
    }
}
