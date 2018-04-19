using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour {

    public GameObject ObjectEmitter;
    public GameObject[] Object;

    public float maxTime = 5;
    public float minTime = 2;

    //current time
    protected float time = 0;

    //The time to spawn the object
    protected float spawnTime;

    protected abstract void Start();

    protected abstract void FixedUpdate();

    //Sets the random time between minTime and maxTime
    protected void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    //Spawns the object and resets the time
    protected abstract void SpawnObject();

}
