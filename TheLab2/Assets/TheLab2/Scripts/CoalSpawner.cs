using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalSpawner : MonoBehaviour {

    private bool machineStatus;

    public RandomCoalSpawning coalSpawner_;
    //public CoalAudio coalAudio;
    //public BreakCoalSpawner coalBreaker_;
    public FixCoalSpawner fixCoalSpawner_;

	// Use this for initialization
	void Start () {
        machineStatus = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (machineStatus)
        {
            //coalSpawner();
            //PlayAudio();
            //machineStatus = coalBreaker_;
        }
        else if (machineStatus != true) {
            //PlayAudio();
            //FixCoalSpawner();
        }

    }
}
