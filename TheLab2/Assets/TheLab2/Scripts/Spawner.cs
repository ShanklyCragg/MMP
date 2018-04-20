using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Deterines, where to spawn an Object, what Object(s) to spawn, and how often to spawn the Object.
/// </summary>
/// <remarks>
/// This parent class is implemented by CoalSpawner and WaterSpawner
/// </remarks>
public abstract class Spawner : MonoBehaviour {

    // The Spawner object, and the Objects it should spawn.
    public GameObject ObjectEmitter;
    public GameObject[] Object;

    // Base min and max spawn time ranges. To be changed on a spawner by spawner basis.
    public float maxTime = 5;
    public float minTime = 2;

    // Current time since last Object spawn
    protected float time = 0;

    // The time to spawn the object
    protected float spawnTime;

    /// <summary>
    /// Initialise first random timer
    /// </summary>
    protected abstract void Start();

    /// <summary>
    /// Count the time until you need to spawn an object, at which point, set a new random time.
    /// </summary>
    protected abstract void FixedUpdate();

    /// <summary>
    /// Gets a random amount of time between the min and max, after which time we spawn the Object.
    /// </summary>
    protected void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    /// <summary>
    /// Spawns the Object, and resets the time for the next spawn.
    /// </summary>
    protected abstract void SpawnObject();

}
