using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnvironment : MonoBehaviour {

    public Transform TrainCoords;
    public Transform Forest;


    // Use this for initialization
    void Start () {
        for (int i = -50; i <= 50; i = i+10)
        {
            var curForest = Instantiate(Forest, new Vector3(0, 0, i), TrainCoords.rotation);
            curForest.parent = GameObject.Find("Forest").transform;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
