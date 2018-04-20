using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the invironment around the train in order to simulate the train moving.
/// </summary>
public class EnvironmentMover : MonoBehaviour {
	
	/// <summary>
    /// Change the position of the environment every fixed update
    /// </summary>
	void FixedUpdate () {
        this.transform.position -= new Vector3(0, 0, GameMaster.speed / 60);
	}
}
