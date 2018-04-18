using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTime : MonoBehaviour {

    private TextMesh textObject;

    // Use this for initialization
    void Start () {
        textObject = this.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update () {
        if (GameMaster.state != 6)
        {

            textObject.text = ("Time: " + Time.fixedTime.ToString("F2"));
        }
    }
}
