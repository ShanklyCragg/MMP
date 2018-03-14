using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherTrigger : MonoBehaviour {

    public string tagToCompare = "Coal";

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root.tag == tagToCompare)
        {
            Debug.Log("coal entered");
            Destroy(col.gameObject);
        }
    }
}
