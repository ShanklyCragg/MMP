using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestDeleter : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        col.transform.position += new Vector3(0, 0, 100);
    }

}
