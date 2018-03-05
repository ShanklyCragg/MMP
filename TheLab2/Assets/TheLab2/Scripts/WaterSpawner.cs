using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{

    public GameObject Water_Emitter;
    public GameObject Water;

    public float maxTime = 5;
    public float minTime = 2;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        //Instantiate time, and initialise first random timer
        time = 0;
        SetRandomTime();
    }

    void FixedUpdate()
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

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    //Spawns the object and resets the time
    void SpawnObject()
    {
        //Reset time to start
        time = 0;

        //The Object instantiation happens here.
        GameObject TemporaryCoalHandler;
        TemporaryCoalHandler = Instantiate(Water, Water_Emitter.transform.position, Water_Emitter.transform.rotation) as GameObject;

        //Retrieve the Rigidbody component from the instantiated Bullet and control it.
        Rigidbody Temporary_RigidBody;
        Temporary_RigidBody = TemporaryCoalHandler.GetComponent<Rigidbody>();
    }

}