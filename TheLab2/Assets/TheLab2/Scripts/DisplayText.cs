using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Update the in game text to update the user with dynamic text.
/// </summary>
public abstract class DisplayText : MonoBehaviour
{

    protected TextMesh textObject;

    /// <summary>
    /// fetches the text mesh so it can be edited
    /// </summary>
    protected void Start()
    {
        textObject = this.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    protected abstract void Update();
}
