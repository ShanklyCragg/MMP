using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

    enum States {Introduction, Start, StartingToFail, NearlyFailed, End};

    // Use this for initialization
    void Start () {
        GameMaster.state = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (GameMaster.state == 0)
        {
            //Say introduction phrase
            GameMaster.state = 1;
        }
        else if (GameMaster.state == 1 && GameMaster.score < 8000)
        {
            GameMaster.state = 2;
        }
        else if (GameMaster.state == 2 && GameMaster.score < 6000)
        {
            GameMaster.state = 3;
        }
        else if (GameMaster.state == 3 && GameMaster.score < 4000)
        {
            GameMaster.state = 4;
        }
        else if (GameMaster.state == 4 && GameMaster.score < 2000)
        {
            GameMaster.state = 5;
        }
        else if (GameMaster.state == 5 && GameMaster.score < 2000)
        {
            GameMaster.state = 6;
            //This is where the game ends
        }
    }
}
