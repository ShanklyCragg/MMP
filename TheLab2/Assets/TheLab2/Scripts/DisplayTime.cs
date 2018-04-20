using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Update the in game text to display the amount of time the current game has lasted for.
/// </summary>
public class DisplayTime : DisplayText {

    /// <summary>
    /// As long as the game isn't over (meaning not gamestate 6). 
    /// Show the current time since the start of this run.
    /// </summary>
    protected override void Update () {
        if (GameMaster.state != 6)
        {
            //totalTime is the time as of the last reset. Taking this away from Time.fixedTime allows us to get the time for the current attempt.
            textObject.text = ("Time: " + (Time.fixedTime - GameMaster.totalTime).ToString("F2"));
        }
    }
}
