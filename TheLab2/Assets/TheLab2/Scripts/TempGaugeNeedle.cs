using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGaugeNeedle : MonoBehaviour {

    public float Temperature;
    private Vector3 currentAngle;

    public GameObject coalGuage;

    private CoalGaugeNeedle _coalGuageScript;


    // Use this for initialization
    void Start()
    {
        _coalGuageScript = coalGuage.GetComponent<CoalGaugeNeedle>();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    void FixedUpdate()
    {
        CalculateTemperature();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    void CalculateTemperature()
    {
        if (Temperature >= 0 && Temperature <= 180)
        {
            if (_coalGuageScript.coalAmount > 150)
            {
                Temperature += 0.05f;
            }
            else if (_coalGuageScript.coalAmount < 50)
            {
                Temperature += 0.01f;
            }
            else
            {
                Temperature += 0.02f;
            }
        }
    }

    Vector3 CalculateCurrentAngle()
    {
        return new Vector3(Temperature - 90, 90, 0);
    }

}
