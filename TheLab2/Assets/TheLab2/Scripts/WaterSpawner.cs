using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawn water Objects for use as coolent into the water entrance
/// </summary>
public class WaterSpawner : Spawner
{

    /// <summary>
    /// Initialise first random timer
    /// </summary>
    protected override void Start()
    {
        SetRandomTime();
    }

    /// <summary>
    /// Count the time until you need to spawn an object, at which point, set a new random time.
    /// </summary>
    protected override void FixedUpdate()
    {
        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
    }

    /// <summary>
    /// Spawns the Object, and resets the time for the next spawn.
    /// </summary>
    /// <remarks>
    /// To mimick the hectic nature of water, we randomise the spawn point to create a shower like effect
    /// </remarks>
    protected override void SpawnObject()
    {
        //Reset time to start
        time = 0;

        //Set random position to spawn particle
        float randPosX = Random.Range(-0.08f, 0.08f);
        float randPosZ = Random.Range(-0.08f, 0.08f);
        Vector3 randPosArray = new Vector3(randPosX, 0, randPosZ);

        //The Object instantiation happens here.
        GameObject TemporaryObjectHandler;
        TemporaryObjectHandler = Instantiate(Object[0], (ObjectEmitter.transform.position + randPosArray), ObjectEmitter.transform.rotation) as GameObject;
    }

}