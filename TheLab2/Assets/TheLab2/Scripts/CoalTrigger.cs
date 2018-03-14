using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalTrigger : MonoBehaviour
{

    public string tagToCompare = "Coal";
    public GameObject coalGuage;

    private CoalGaugeNeedle _coalGuageScript;

    void OnTriggerEnter(Collider col)
    {

        if (col.transform.root.tag == tagToCompare)
        {
            Debug.Log("coal entered");
            _coalGuageScript = coalGuage.GetComponent<CoalGaugeNeedle>();
            _coalGuageScript.coalAmount += 5;
            //Destroy(col.gameObject, 3);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}
