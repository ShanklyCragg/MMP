using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Determines the angle the Coal Gauge Needle should point at.
/// Based on amount of Coal.
/// Determines how much to decrease coal amount by every fixed update.
/// This increases the every fixed update up to a maximum.
/// </summary>
/// <remarks>
/// This class controls the Coal gauge and its needle.
/// </remarks>
public class CoalGaugeNeedle : Gauge {

    public float deteriationSpeed;
    public float deteriationIncrease;
    public float deteriationMax;

    /// <summary>
    /// Runs the necessary functions to correctly update the position of the needle
    /// </summary>
    protected override void FixedUpdate () {
        UpdateCoalAmount();
        UpdateDeteriationSpeed();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    /// <summary>
    /// As long as there is more than zero coal, decrease the coal amount by the deteriation amount.
    /// </summary>
    void UpdateCoalAmount()
    {
        if (GameMaster.coal >= MinAmount)
        {
            GameMaster.coal -= deteriationSpeed;
        }
    }

    /// <summary>
    /// As long as the deteriation speed is less than the max deteriation speed, increase the deteriation speed.
    /// </summary>
    void UpdateDeteriationSpeed()
    {
        if (deteriationSpeed <= deteriationMax)
        {
            deteriationSpeed += deteriationIncrease;
        }
    }

    /// <summary>
    /// Calculates the angles for the Vector3 belonging to the needle.
    /// </summary>
    /// <returns>
    /// A Vector3 angle for the coal gauge needle
    /// </returns>
    protected override Vector3 CalculateCurrentAngle()
    {
        return new Vector3(0, (MaxAmount / 2), GameMaster.coal - (MaxAmount / 2));
    }

}
