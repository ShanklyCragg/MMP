using UnityEngine;
using VRTK;
using System.Collections;

//h ttps://github.com/thestonefox/VRTK/issues/643
public class FixCoalSpawner : MonoBehaviour
{

    private int count = 0;

    void Start()
    {
        CreateTouchEvent();
    }

    //Hook into vrtk interactable object to inject my own functions
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

    //my custom event function
    private void ObjectTouched(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log("Im Touched");

        count += 1;

        if (count == 3)
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
