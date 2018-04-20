using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Restrict the area an object can move in
/// </summary>
public class RestrictMovement : MonoBehaviour {

    public float xLower = -1000;
    public float xUpper = 1000;

    public float yLower = -1000;
    public float yUpper = 1000;

    public float zLower = -1000;
    public float zUpper = 1000;

	
    /// <summary>
    /// Restrict the movement
    /// </summary>
	void Update () {
        RestrictPositionMovement();
    }

    /// <summary>
    /// Check if the object is out of the defined bounds. 
    /// If so, move it into the bounds.
    /// </summary>
    private void RestrictPositionMovement()
    {
        if (this.transform.position.x < xLower)
        {
            this.transform.position = new Vector3(xLower, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > xUpper)
        {
            this.transform.position = new Vector3(xUpper, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.y < yLower)
        {
            this.transform.position = new Vector3(this.transform.position.x, yLower, this.transform.position.z);
        }
        if (this.transform.position.y > yUpper)
        {
            this.transform.position = new Vector3(this.transform.position.x, yUpper, this.transform.position.z);
        }
        if (this.transform.position.z < zLower)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, zLower);
        }
        if (this.transform.position.z > zUpper)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, zUpper);
        }
    }

}

