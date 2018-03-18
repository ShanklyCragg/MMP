using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGaugeNeedle : MonoBehaviour {

    public float temperature;

    public const float tempAmountMax = 180;
    public const float tempAmountMin = 0;

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
        if (temperature <= tempAmountMax)
        {
            if (_coalGuageScript.coalAmount > 150)
            {
                temperature += 0.05f;
            }
            else if (_coalGuageScript.coalAmount < 50)
            {
                temperature += 0.01f;
            }
            else
            {
                temperature += 0.02f;
            }
        }
    }

    Vector3 CalculateCurrentAngle()
    {
        return new Vector3(0, (tempAmountMax/2), temperature - (tempAmountMax/2));
    }

}
