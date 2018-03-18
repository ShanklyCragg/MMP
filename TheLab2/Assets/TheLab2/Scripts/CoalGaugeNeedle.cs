using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalGaugeNeedle : MonoBehaviour {

    //over 140 is dangerous, under 50 is critically low
    public float coalAmount;

    public const float coalAmountMax = 180;
    public const float coalAmountMin = 0;

    public float deteriationSpeed;
    public float deteriationIncrease;
    public float deteriationMax;

    private Vector3 currentAngle;

    // Use this for initialization
    void Start () {
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
	}
	
	void FixedUpdate () {
        coalAmount = UpdateCoalAmount();
        deteriationSpeed = UpdateDeteriationSpeed();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    float UpdateCoalAmount()
    {
        if (coalAmount >= coalAmountMin)
        {
            coalAmount -= deteriationSpeed;
        }
        return coalAmount;
    }

    float UpdateDeteriationSpeed()
    {
        if (deteriationSpeed <= deteriationMax)
        {
            deteriationSpeed += deteriationIncrease;
        }
        return deteriationSpeed;
    }

    Vector3 CalculateCurrentAngle()
    {
        return new Vector3(0, (coalAmountMax / 2), coalAmount - (coalAmountMax/2));
    }

}
