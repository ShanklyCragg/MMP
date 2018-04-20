using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Update the in game text to display the score for this session.
/// </summary>
public class DisplayScore : DisplayText {


    /// <summary>
    /// As long as the game isn't over (meaning not gamestate 6). 
    /// Show the current score of this run.
    /// </summary>
    protected override void Update()
    {
        if (GameMaster.state != 6)
        {
            //Make the score more human parsable 
            float score = GameMaster.score / 100;
            textObject.text = ("Score: " + score.ToString());
        }
    }
}
