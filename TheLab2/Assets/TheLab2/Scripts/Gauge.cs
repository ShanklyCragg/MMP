using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Determines the angle the Gauge Needle should point at.
/// Based on amount of substance between min and max amount.
/// </summary>
/// <remarks>
/// This parent class is implemented by CoalGaugeNeedle and TempGaugeNeedle
/// </remarks>
public abstract class Gauge : MonoBehaviour {

    public const float MaxAmount = 180;
    public const float MinAmount = 0;

    /// <summary>
    /// Set's the initial angle of the needle
    /// </summary>
    protected void Start()
    {
        this.transform.rotation = Quaternion.Euler(CalculateCurrentAngle());
    }

    /// <summary>
    /// Runs the necessary functions to correctly update the position of the needle
    /// </summary>
    protected abstract void FixedUpdate();

    /// <summary>
    /// Calculates the angles for the Vector3 belonging to the needle.
    /// </summary>
    /// <returns>
    /// A Vector3 angle for the gauge needle
    /// </returns>
    protected abstract Vector3 CalculateCurrentAngle();

}
