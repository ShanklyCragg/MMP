using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    private const float SpeedDecrement = 0.001f;
    private const float SpeedIncrement = 0.0002f;

    // Use this for initialization
    void Start () {
        GameMaster.score = 10000;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //Debug.Log(GameMaster.score);
        //Debug.Log(GameMaster.speed);
        CalculateSpeed();

    }

    private void CalculateSpeed()
    {
        if (GameMaster.speed > 0)
        {
            if (CoalWrong())
            {
                GameMaster.speed -= SpeedDecrement;
                if (CoalSuperWrong())
                {
                    GameMaster.speed -= SpeedDecrement;
                }
            }
            else
            {
                if (GameMaster.speed <= GameMaster.maxSpeed)
                {
                    GameMaster.speed += SpeedIncrement;
                }
            }
            if (WaterWrong())
            {
                GameMaster.speed -= SpeedDecrement;
                if (WaterSuperWrong())
                {
                    GameMaster.speed -= SpeedDecrement;
                }
            }
            else
            {
                if (GameMaster.speed <= GameMaster.maxSpeed)
                {
                    GameMaster.speed += SpeedIncrement;
                }
            }

            if (GameMaster.speed < GameMaster.maxSpeed / 2)
            {
                GameMaster.score -= 3;
            }
            if (GameMaster.speed < 0.03f)
            {
                GameMaster.score = 0;
            }
        }
    }

    private bool CoalWrong()
    {
        if (GameMaster.coal < GameMaster.lowerCoalWarning || GameMaster.coal > GameMaster.upperCoalWarning)
        {
            return true;
        }
        return false;
    }

    private bool CoalSuperWrong()
    {
        if (GameMaster.coal < GameMaster.lowerCoalLimit || GameMaster.coal > GameMaster.upperCoalLimit)
        {
            return true;
        }
        return false;
    }

    private bool WaterWrong()
    {
        if (GameMaster.temperature > GameMaster.waterWarning)
        {
            return true;
        }
        return false;
    }

    private bool WaterSuperWrong()
    {
        if (GameMaster.temperature > GameMaster.waterLimit)
        {
            return true;
        }
        return false;
    }
}
