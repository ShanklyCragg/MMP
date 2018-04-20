using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherTrigger : MonoBehaviour {

    private const string TagToCompare = "Coal";

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root.tag == TagToCompare)
        {
            Debug.Log("coal entered");
            Destroy(col.gameObject);
        }
    }
}
