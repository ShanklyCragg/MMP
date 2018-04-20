﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameMaster
{

    public const float MaxSpeed = 20;
    public const float LowerCoalWarning = 73;
    public const float LowerCoalLimit = 55;
    public const float UpperCoalWarning = 132;
    public const float UpperCoalLimit = 145;
    public const float WaterWarning = 70;
    public const float WaterLimit = 110;
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
