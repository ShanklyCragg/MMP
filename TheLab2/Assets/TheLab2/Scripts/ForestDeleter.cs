using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Once the forest piece has travelled sufficient distance, move it to the front of the environment
/// </summary>
public class ForestDeleter : MonoBehaviour
{

    /// <summary>
    /// Once the forest collides with the trigger, move the forest forward
    /// </summary>
    /// <param name="col"> The collider belonging to the object which entered the trigger </param>
    void OnTriggerEnter(Collider col)
    {
        col.transform.position += new Vector3(0, 0, 100);
    }

}
