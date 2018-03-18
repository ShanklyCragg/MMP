using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDeleter : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Destroy(this.gameObject, 13);
    }

    void Update()
    {
        if (this.transform.position.y < 0.5)
        {
            Destroy(this.gameObject);
        }
    }

}
