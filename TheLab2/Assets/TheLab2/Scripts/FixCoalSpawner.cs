using UnityEngine;
using VRTK;
using System.Collections;

/// <summary>
/// Fix the coal spawner by "hitting" it 3 times
/// </summary>
public class FixCoalSpawner : MonoBehaviour
{

    private int count = 0;
    private const int countNeeded = 3;

    /// <summary>
    /// Create the custom event
    /// </summary>
    void Start()
    {
        CreateTouchEvent();
    }

    /// <summary>
    /// Add a new custom event to the VRTK interaction event handler.
    /// </summary>
    /// <remarks>
    /// This code is my adaptation of a github issue which can be seen here https://github.com/thestonefox/VRTK/issues/643
    /// My work is transformative but not wholly original.
    /// </remarks>
    private void CreateTouchEvent()
    {
        //make sure the object has the VRTK script attached. 
        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError("VRTK_InteractableObject needed");
            return;
        }

        //hook into event
        GetComponent<VRTK_InteractableObject>().InteractableObjectTouched += new InteractableObjectEventHandler(ObjectTouched);
    }

    /// <summary>
    /// Count number of times coal spawner is hit.
    /// Once it has been hit the required number of times, begin spawning coal again
    /// </summary>
    /// <param name="sender"> The Object being touched </param>
    /// <param name="e"> Information regarding the touch event </param>
    private void ObjectTouched(object sender, InteractableObjectEventArgs e)
    {

        count += 1;

        if (count == countNeeded)
        {
            count = 0;

            //turn on coal spawner script
            (GetComponent("RandomCoalSpawning") as MonoBehaviour).enabled = true;

            //turn off this script
            (GetComponent("FixCoalSpawner") as MonoBehaviour).enabled = false;

            //Turn off smoke effect
            transform.Find("WhiteSmoke").gameObject.SetActive(false);

        }

    }

}
