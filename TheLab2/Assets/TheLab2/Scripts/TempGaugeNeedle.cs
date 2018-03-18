using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGaugeNeedle : MonoBehaviour {

    public const float tempAmountMax = 180;
    public const float tempAmountMin = 0;

    // Use this for initialization
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    void FixedUpdate()
    {
        CalculateTemperature();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    void CalculateTemperature()
    {
        if (GameMaster.temperature <= tempAmountMax)
        {
            if (GameMaster.coal > 150)
            {
                GameMaster.temperature += 0.05f;
            }
            else if (GameMaster.coal < 50)
            {
                GameMaster.temperature += 0.01f;
            }
            else
            {
                GameMaster.temperature += 0.02f;
            }
        }
    }

    Vector3 CalculateCurrentAngle()
    {
        return new Vector3(0, (tempAmountMax/2), GameMaster.temperature - (tempAmountMax/2));
    }

}
