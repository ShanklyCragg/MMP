using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Update the in game text to display the speed of the train.
/// </summary>
public class DisplaySpeed : DisplayText {

    /// <summary>
    /// As long as the game isn't over (meaning not gamestate 6). 
    /// Show the current speed of the train.
    /// </summary>
    protected override void Update()
    {
        if (GameMaster.state != 6)
        {
            textObject.text = ("Speed: " + GameMaster.speed.ToString("F2"));
        }
    }
}
