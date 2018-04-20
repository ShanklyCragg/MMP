using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Restrict the rotational room for an object
/// </summary>
public class RestrictRotation : MonoBehaviour {

    public float xLowerRot = 0;
    public float xUpperRot = 360;

    public float yLowerRot = 0;
    public float yUpperRot = 360;

    public float zLowerRot = 0;
    public float zUpperRot = 360;


    /// <summary>
    /// Restrict the rotation
    /// </summary>
    void Update () {
        RestrictRotationMovement();
    }

    /// <summary>
    /// Check if the object is out of the defined bounds. 
    /// If so, spin it into the bounds.
    /// </summary>
    private void RestrictRotationMovement()
    {

        Vector3 p = this.transform.rotation.eulerAngles;

        //if (this.transform.rotation.eulerAngles.x < xLowerRot && this.transform.rotation.eulerAngles.x > yUpperRot)
        //{
        //    p.x = xLowerRot;
        //    this.transform.rotation = Quaternion.Euler(p);
        //}
        //if (this.transform.rotation.eulerAngles.x > xUpperRot && this.transform.rotation.eulerAngles.x < xLowerRot)
        //{
        //    p.x = xUpperRot;
        //    this.transform.rotation = Quaternion.Euler(p);
        //}
        //if (this.transform.rotation.eulerAngles.y < yLowerRot && this.transform.rotation.eulerAngles.y > yUpperRot)
        //{
        //    p.y = yLowerRot;
        //    this.transform.rotation = Quaternion.Euler(p);
        //}
        //if (this.transform.rotation.eulerAngles.y > yUpperRot && this.transform.rotation.eulerAngles.y < yLowerRot)
        //{
        //    p.y = yUpperRot;
        //    this.transform.rotation = Quaternion.Euler(p);
        //}
        if (this.transform.rotation.eulerAngles.z < zLowerRot && this.transform.rotation.eulerAngles.z > zUpperRot + 5)
        {
            p.z = zLowerRot;
            this.transform.rotation = Quaternion.Euler(p);
        }
        if (this.transform.rotation.eulerAngles.z > zUpperRot && this.transform.rotation.eulerAngles.z < zLowerRot - 5)
        {
            p.z = zUpperRot;
            this.transform.rotation = Quaternion.Euler(p);
        }
    }

}
