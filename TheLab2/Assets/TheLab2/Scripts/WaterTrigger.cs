using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{

    private string tagToCompare = "Water";

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.root.tag == tagToCompare)
        {
            if (GameMaster.temperature >= 0)
            {
                GameMaster.temperature -= 1f;
            }
            Destroy(col.gameObject);
        }
    }
}
