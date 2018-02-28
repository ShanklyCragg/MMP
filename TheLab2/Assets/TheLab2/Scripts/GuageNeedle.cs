﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuageNeedle : MonoBehaviour {

    //over 140 is dangerous, under 50 is critically low
    public float coalAmount = 140;
    public float deteriationSpeed = 0.001f;
    public float deteriationIncrease = 0.00005f;
    //private Vector3 currentAngle = new Vector3(50, 0, 0);
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
        if (coalAmount >= 0)
        {
            coalAmount -= deteriationSpeed;
        }
        return coalAmount;
    }

    float UpdateDeteriationSpeed()
    {
        if (deteriationSpeed <= 0.2)
        {
            deteriationSpeed += deteriationIncrease;
        }
        return deteriationSpeed;
    }

    Vector3 CalculateCurrentAngle()
    {
        return new Vector3(coalAmount - 90, 90, 0);
    }

}
