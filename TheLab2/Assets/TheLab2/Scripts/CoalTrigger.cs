using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalTrigger : MonoBehaviour
{

    public string tagToCompare = "Coal";
    public GameObject coalGuage;

    private GuageNeedle _coalGuageScript;

    void OnTriggerEnter(Collider col)
    {

        if (col.transform.root.tag == tagToCompare)
        {
            Debug.Log("coal entered");
            _coalGuageScript = coalGuage.GetComponent<GuageNeedle>();
            _coalGuageScript.coalAmount += 5;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}
