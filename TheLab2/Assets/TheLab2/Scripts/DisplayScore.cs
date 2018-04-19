using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScore : MonoBehaviour {

    private TextMesh textObject;

    // Use this for initialization
    void Start()
    {
        textObject = this.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMaster.state != 6)
        {
            float score = GameMaster.score / 100;
            textObject.text = ("Score: " + score.ToString());
        }
    }
}
