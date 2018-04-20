using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows the user to "pump" a lever to spawn water
/// </summary>
public class PumpWater : MonoBehaviour {

    public GameObject otherObject;
    private bool pumpReady = true;

	
    /// <summary>
    /// Check if we are looking for a pump or unpump action (Up or down movement)
    /// </summary>
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

    /// <summary>
    /// If we are expecting a pump, check for a pump.
    /// Enable the water spawner for x seconds depending on the number in the coroutine
    /// </summary>
    private void SeeIFTryingToPump()
    {
        //If Successfully Pumped
        if (this.transform.position.y < (transform.GetComponent<RestrictMovement>().yLower + 0.02f))
        {
            pumpReady = false;

            //enable script here
            otherObject.GetComponent<WaterSpawner>().enabled = true;

            //coroutine disables script after 3 seconds
            StartCoroutine("DisableScript");
        }
    }

    /// <summary>
    /// After a certain number of seconds, disable the water spawner
    /// </summary>
    IEnumerator DisableScript()
    {
        yield return new WaitForSeconds(3f);

        //disable script here
        otherObject.GetComponent<WaterSpawner>().enabled = false;
    }

    /// <summary>
    /// We are checking to see if the user has unpumped
    /// If so, start checking for a pump
    /// </summary>
    private void SeeIfSuccessfullyUnpumped()
    {
        //If they have successfully unpumped
        if (this.transform.position.y > transform.GetComponent<RestrictMovement>().yUpper - 0.02f)
        {
            pumpReady = true;
            //otherObject.GetComponent<WaterSpawner>().enabled = false;
        }
    }


}
