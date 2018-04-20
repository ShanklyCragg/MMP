using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detect if coal was touched by crusher, and remove the coal piece
/// </summary>
public class CrusherTrigger : MonoBehaviour {

    private const string TagToCompare = "Coal";

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root.tag == TagToCompare)
        {
            Destroy(col.gameObject);
            if (GameMaster.coal < 176)
            {
                GameMaster.coal += 5;
            }
        }
    }
}
