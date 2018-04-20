using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Keeps track of current game state.
/// </summary>
public class StateManager : MonoBehaviour {

    /// <summary>
    /// Start off in initial game state
    /// </summary>
    void Start () {
        GameMaster.state = 0;
	}
	
	/// <summary>
    /// Check the current game state
    /// Once game is over, check if the user wants to restart
    /// </summary>
	void FixedUpdate () {
        if (GameMaster.state == 0)
        {
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
        else if (GameMaster.state == 5 && GameMaster.score < 5)
        {
            GameMaster.state = 6;
        }
        else if (GameMaster.state == 6)
        {
            GameMaster.totalTime = Time.fixedTime;

            //if certain button pressed, reset scene with SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
            if (Input.GetAxis("openvr-r-trigger-press") > 0.1) {
                GameMaster.Reset();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
