using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSpaceSpawnCoal : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Coal_Emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    //public GameObject CoalA;
    //public GameObject CoalB;
    //public GameObject CoalC;

    public GameObject[] Coals;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {

            //Max int is exclusive
            int rnd = Random.Range(0, 3);

            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Coals[rnd], Coal_Emitter.transform.position, Coal_Emitter.transform.rotation) as GameObject;

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            //Destroy(Temporary_Bullet_Handler, 10.0f);
        }
    }
}