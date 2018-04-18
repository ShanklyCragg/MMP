using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour {

    // Use this for initialization
    void Start () {
        GameMaster.state = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Debug.Log(GameMaster.state);
        Debug.Log(GameMaster.score);
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
            //This is where the game ends
            //show time.fixedTime;
        }
        else if (GameMaster.state == 6)
        {
            //if certain button pressed, reset scene with SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
