using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detect if coal was touched by crusher, and remove the coal piece
/// </summary>
public class CrusherTrigger : MonoBehaviour {

    private const string TagToCompare = "Coal";

    /// <summary>
    /// When an object enters the trigger, check if the object is a piece of coal
    /// If it is, delete it, and increment the coal counter so long as it would not "overcharge" the coal counter.
    /// </summary>
    /// <param name="col">
    /// Collider Component of object which triggered collider. 
    /// </param>
    void OnTriggerEnter(Collider col)
    {
        //Check if object is "Coal"
        if (col.transform.root.tag == TagToCompare)
        {

            //REmove the coal object
            Destroy(col.gameObject);

            //Check incrementing the coal wouldn't "overcharge" it
            if (GameMaster.coal < 176)
            {
                GameMaster.coal += 5;
            }
        }
    }
}
