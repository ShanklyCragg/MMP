using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Allow the object to be summoned in front of the user
/// </summary>
public class ObjectToHand : MonoBehaviour
{

    private UnityAction someListener;


    /// <summary>
    /// Once the object this is attached to spawns, create the listener
    /// </summary>
    private void Awake()
    {
        someListener = new UnityAction(ObjectIntoHand);
    }

    /// <summary>
    /// Once the object this is attached to spawns, create the listener
    /// </summary>
    private void OnEnable()
    {
        EventManager.StartListening("ObjectIntoHand", someListener);
    }

    /// <summary>
    /// Stop listening on disable to avoid wasting memory
    /// </summary>
    private void OnDisable()
    {
        EventManager.StopListening("ObjectIntoHand", someListener);
    }

    /// <summary>
    /// Move the object into position to be grabbed by the right controller
    /// Reset the velocity and angular velocity so it acts as the user imagines it should
    /// </summary>
    void ObjectIntoHand()
    {
        var controller = GameObject.FindGameObjectsWithTag("RightController");

        this.transform.rotation = Quaternion.Euler(0, 180, 0);

        this.transform.position = controller[0].transform.position + new Vector3(0, 0, 0.9f);
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

}
