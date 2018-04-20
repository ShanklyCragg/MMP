using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalTrigger : MonoBehaviour
{

    public const string TagToCompare = "Coal";


    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root.tag == TagToCompare && GameMaster.coal < 176)
        {
            Debug.Log("coal entered");
            GameMaster.coal += 5;
        }
    }
}
