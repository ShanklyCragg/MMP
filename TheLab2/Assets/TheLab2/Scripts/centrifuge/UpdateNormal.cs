using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateNormal : MonoBehaviour
{

    private Vector3 surfaceNormal;
    private Vector3 personalNormal;
    private float personalGravity = 9.8f;
    private float normalSwitchRange = 1000;

    public void Start()
    {
        personalNormal = transform.up; // Start with "normal" normal
    }

    // Update is called once per frame
    public void Update()
    {



        RaycastHit hit = new RaycastHit(); //hit register
                        // list of valid normals to check (all 6 axis)
        Vector3[] rays =
            {
        Vector3.up, Vector3.down,
        Vector3.left, Vector3.right,
        Vector3.forward, Vector3.back
        };

        //for each valid normal...
        foreach (Vector3 rayDirection in rays)
        {

            //check if we are near a cube face...
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                Debug.DrawRay(transform.position, rayDirection * hit.distance, Color.green, 4, true);

                if(personalNormal != hit.normal)
                {
                    personalNormal = hit.normal; //set personal normal ...



                    Physics.gravity = -personalNormal;

                    //transform.position = hit.point;
                    var q = Quaternion.FromToRotation(transform.up, hit.normal);
                    transform.rotation = q * transform.rotation;
                }

                return; // and return as we are done
            }
            else
            {
                Debug.DrawRay(transform.position, rayDirection * normalSwitchRange, Color.green, 4, true);
                //ohno never lucky
            }

        }
    }
}