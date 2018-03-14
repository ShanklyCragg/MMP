using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoalSpawning : MonoBehaviour
{

    public GameObject ObjectEmitter;
    public GameObject[] Object;

    public float maxTime = 5;
    public float minTime = 2;
    public float maxTimeLowerLimit = 0.31f;
    public float minTimeLowerLimit = 0.51f;

    public AudioSource MachineRunning;
    public AudioSource MachineBreaking;


    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;


    void Start()
    {
        //Instantiate time, and initialise first random timer
        time = 0;
        SetRandomTime();
        MachineRunning.Play();
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
            BreakMachine();
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
        int rnd = Random.Range(0, 3);

        //The Object instantiation happens here.
        GameObject TemporaryObjectHandler;
        TemporaryObjectHandler = Instantiate(Object[rnd], ObjectEmitter.transform.position, ObjectEmitter.transform.rotation) as GameObject;

        //Retrieve the Rigidbody component from the instantiated Bullet and control it.
        Rigidbody Temporary_RigidBody;
        Temporary_RigidBody = TemporaryObjectHandler.GetComponent<Rigidbody>();
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