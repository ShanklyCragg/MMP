using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameMaster
{

    public const float maxSpeed = 20;
    public const float lowerCoalWarning = 73;
    public const float lowerCoalLimit = 55;
    public const float upperCoalWarning = 132;
    public const float upperCoalLimit = 145;
    public const float waterWarning = 70;
    public const float waterLimit = 110;
    public static float totalTime = 0;


    public static float coal = 110;
    public static float temperature = 0;
    public static float speed = 15;
    public static int score;
    public static int state;

    public static void Reset()
    {
        coal = 110;
        temperature = 0;
        speed = 15;
    }

}
