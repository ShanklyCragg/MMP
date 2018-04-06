using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestDeleter : MonoBehaviour {

    private string tagToCompare = "Forest";

    void OnTriggerEnter(Collider col)
    {
        //if (col.transform.root.tag == tagToCompare)
        //{
            Debug.Log("forestdeleter was entered!");
            Destroy(col.gameObject);
        //}
    }

}
