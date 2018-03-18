using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalGaugeNeedle : MonoBehaviour {

    public const float coalAmountMax = 180;
    public const float coalAmountMin = 0;

    public float deteriationSpeed;
    public float deteriationIncrease;
    public float deteriationMax;

    // Use this for initialization
    void Start () {
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
	}
	
	void FixedUpdate () {
        GameMaster.coal = UpdateCoalAmount();
        deteriationSpeed = UpdateDeteriationSpeed();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    float UpdateCoalAmount()
    {
        if (GameMaster.coal >= coalAmountMin)
        {
            GameMaster.coal -= deteriationSpeed;
        }
        return GameMaster.coal;
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
        return new Vector3(0, (coalAmountMax / 2), GameMaster.coal - (coalAmountMax/2));
    }

}
