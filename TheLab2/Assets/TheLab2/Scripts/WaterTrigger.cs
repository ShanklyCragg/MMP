using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{

    private string tagToCompare = "Water";

    /// <summary>
    /// When an object enters the trigger, check if the object is water
    /// If it is, delete it, and decrease the temperature as long as it's over 0.
    /// </summary>
    /// <param name="col">
    /// Collider Component of object which triggered collider. 
    /// </param>
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root.tag == tagToCompare)
        {
            if (GameMaster.temperature >= 0)
            {
                GameMaster.temperature -= 1f;
            }
            Destroy(col.gameObject);
        }
    }
}
