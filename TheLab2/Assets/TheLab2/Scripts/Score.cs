using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameMaster.score = 10000;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //Debug.Log(GameMaster.score);
        if (GameMaster.score != 0)
        {
            if (CoalWrong())
            {
                GameMaster.score -= 1;
            }
            if (WaterWrong())
            {
                GameMaster.score -= 1;
            }
        }
	}

    public bool CoalWrong()
    {
        if (GameMaster.coal < 45 || GameMaster.coal > 135)
        {
            return true;
        }
        return false;
    }

    public bool WaterWrong()
    {
        if (GameMaster.coal < 45 || GameMaster.coal > 135)
        {
            return true;
        }
        return false;
    }

}
