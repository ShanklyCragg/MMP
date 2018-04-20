using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Create the environment at run time
/// </summary>
public class SpawnEnvironment : MonoBehaviour {

    public Transform TrainCoords;
    public Transform Forest;


    /// <summary>
    /// Loop through creating a long forest out of an existing forest prefab
    /// </summary>
    void Start () {
        for (int i = -30; i <= 70; i = i+10)
        {
            var curForest = Instantiate(Forest, new Vector3(0, 0, i), TrainCoords.rotation);
            curForest.parent = GameObject.Find("Forest").transform;
        }
    }
}
