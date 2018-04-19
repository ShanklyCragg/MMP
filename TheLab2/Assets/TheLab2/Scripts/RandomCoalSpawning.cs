using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 */

public class RandomCoalSpawning : Spawner
{
    public float maxTimeLowerLimit = 0.31f;
    public float minTimeLowerLimit = 0.51f;

    public AudioSource MachineRunning;
    public AudioSource MachineBreaking;

    protected override void Start()
    {
        //Instantiate time, and initialise first random timer
        time = 0;
        SetRandomTime();
        MachineRunning.Play();
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
            BreakMachine();
        }
    }

    //Spawns the object and resets the time
    protected override void SpawnObject()
    {
        //Reset time to start
        time = 0;

        //Reduce timers slightly to a minmum
        if (minTime > minTimeLowerLimit)
        {
            minTime -= 0.1f;
        }
        if (maxTime > maxTimeLowerLimit)
        {
            maxTime -= 0.1f;
        }

        //Max int is exclusive
        int rnd = Random.Range(0, Object.Length);

        //The Object instantiation happens here.
        GameObject TemporaryObjectHandler;
        TemporaryObjectHandler = Instantiate(Object[rnd], ObjectEmitter.transform.position, ObjectEmitter.transform.rotation) as GameObject;
    }


    void BreakMachine()
    {
        int isBreak = Random.Range(0, 1000);
        if (isBreak < 50)
        {
            (GetComponent("RandomCoalSpawning") as MonoBehaviour).enabled = false;
            (GetComponent("FixCoalSpawner") as MonoBehaviour).enabled = true;
            transform.Find("WhiteSmoke").gameObject.SetActive(true);
            MachineRunning.Stop();
            MachineBreaking.Play();
        }
    }

}