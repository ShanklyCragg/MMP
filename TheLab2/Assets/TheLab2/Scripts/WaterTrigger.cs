using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{

    public string tagToCompare = "Water";
    public GameObject tempGuage;

    private TempGaugeNeedle _tempGuageScript;

    void OnTriggerEnter(Collider col)
    {

        if (col.transform.root.tag == tagToCompare)
        {
            Debug.Log("water entered");
            _tempGuageScript = tempGuage.GetComponent<TempGaugeNeedle>();
            if (_tempGuageScript.temperature >= 0)
            {
                _tempGuageScript.temperature -= 1f;
            }
            Destroy(col.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {

    }
}
