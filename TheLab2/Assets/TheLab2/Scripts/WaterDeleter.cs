using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stops the possibility of too much water lagging the game
/// </summary>
public class WaterDeleter : MonoBehaviour {

    /// <summary>
    /// Gives the water object a x second long life span
    /// This stops spawning infinite water to lag the game
    /// </summary>
    void Start () {
        Destroy(this.gameObject, 20);
    }
}
