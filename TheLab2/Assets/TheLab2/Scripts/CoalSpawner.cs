using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawn Coal as fuel for the engine
/// </summary>
/// <remarks>
/// The speed of spawning increases over time 
/// </remarks>
public class CoalSpawner : Spawner
{
    public float maxTimeLowerLimit = 0.31f;
    public float minTimeLowerLimit = 0.51f;

    // Unrefined audio files. Code implemented but audio is disabled due to grating audio negativly effecting experiance.
    public AudioSource MachineRunning;
    public AudioSource MachineBreaking;

    /// <summary>
    /// Initialise first random timer
    /// </summary>
    /// <remarks>
    /// This should start playing audio for coal spawner, but the audio is so unrefined I have the audio files disabled in the editor. Enabling the audio files will cause the audio to work.
    /// </remarks>
    protected override void Start()
    {
        SetRandomTime();
        MachineRunning.Play();
    }

    /// <summary>
    /// Count the time until you need to spawn an object, at which point, set a new random time.
    /// See if the coal machine should randomly break.
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
            BreakMachine();
        }
    }

    /// <summary>
    /// Spawns the Object, and resets the time for the next spawn.
    /// </summary>
    /// <remarks>
    /// There are 3 possible coal rocks that can be spawned, so we randomly select 1 of these each time.
    /// </remarks>
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

    /// <summary>
    /// Every time a piece of coal spawns, the spawner has a chance of "breaking". Once this happens, the user must hit the spawner 3 times to fix. Code seen in "FixCoalSpawner" file.
    /// </summary>
    /// <remarks>
    /// The machine should break on average once every 20 pieces.
    /// </remarks>
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