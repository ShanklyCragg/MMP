using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpWater : MonoBehaviour {

    public GameObject otherObject;
    private bool pumpReady = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (pumpReady == true)
        {
            SeeIFTryingToPump();
        }
        else
        {
            SeeIfSuccessfullyUnpumped();
        }
    }


    private void SeeIFTryingToPump()
    {
        //If Successfully Pumped
        if (this.transform.position.y < (transform.GetComponent<RestrictMovement>().yLower + 0.02f))
        {
            pumpReady = false;

            //enable script here
            otherObject.GetComponent<WaterSpawner>().enabled = true;

            //coroutine disables script after 1 second
            StartCoroutine("DisableScript");
        }
    }


    IEnumerator DisableScript()
    {
        yield return new WaitForSeconds(3f);

        //disable script here
        otherObject.GetComponent<WaterSpawner>().enabled = false;
    }


    private void SeeIfSuccessfullyUnpumped()
    {
        //If they have successfully unpumped
        if (this.transform.position.y > transform.GetComponent<RestrictMovement>().yUpper - 0.02f)
        {
            pumpReady = true;
            otherObject.GetComponent<WaterSpawner>().enabled = false;
        }
    }


}
