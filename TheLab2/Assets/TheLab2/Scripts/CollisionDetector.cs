using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision Collided)
    {
        {
            Destroy(this.gameObject); // Destroy the object this is attached to.
        }
    }

}