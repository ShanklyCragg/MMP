using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : Spawner
{

    protected override void Start()
    {
        //Instantiate time, and initialise first random timer
        time = 0;
        SetRandomTime();
    }

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

    //Spawns the object and resets the time
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