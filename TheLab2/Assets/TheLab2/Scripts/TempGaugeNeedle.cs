using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Determines the angle the Temperature Gauge Needle should point at.
/// Based on temperature which is effected by water.
/// </summary>
/// <remarks>
/// This class controls the Temperature gauge and its needle.
/// </remarks>
public class TempGaugeNeedle : Gauge {

    private const float baseIncrementAmount = 0.03f;

    /// <summary>
    /// Runs the necessary functions to correctly update the position of the needle
    /// </summary>
    protected override void FixedUpdate()
    {
        CalculateTemperature();
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    /// <summary>
    /// The amount of coal determines how much to increase the temperature by each update.
    /// </summary>
    /// <remarks>
    /// More coal = quicker increase
    /// Less coal = slower increase
    /// </remarks>
    void CalculateTemperature()
    {
        if (GameMaster.temperature <= MaxAmount)
        {
            if (GameMaster.coal > GameMaster.UpperCoalLimit)
            {
                GameMaster.temperature += (baseIncrementAmount * 3);
            }
            else if (GameMaster.coal < GameMaster.LowerCoalLimit)
            {
                GameMaster.temperature += baseIncrementAmount;
            }
            else
            {
                GameMaster.temperature += (baseIncrementAmount * 2);
            }
        }
    }

    /// <summary>
    /// Calculates the angles for the Vector3 belonging to the needle.
    /// </summary>
    /// <returns>
    /// A Vector3 angle for the temperature gauge needle
    /// </returns>
    protected override Vector3 CalculateCurrentAngle()
    {
        return new Vector3(0, (MaxAmount / 2), GameMaster.temperature - (MaxAmount / 2));
    }

}
