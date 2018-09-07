using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcCamSize : MonoBehaviour {


    private Vector2[] remoteLocation = new Vector2[] { };

    private int remoteWidth = 640;
    private int remoteHeight = 480;
    private int localWidth = Camera.main.pixelWidth;
    private int localHeight = Camera.main.pixelHeight;

    private float scaleWidth;
    private float scaleHeight;
    private int i;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++)
        {
            Vector2 elem = new Vector2(i + 1, i + 1);
            remoteLocation[i] = elem;
        }

        i = remoteLocation.Length;

        scaleHeight = remoteHeight / localHeight;
        scaleWidth = remoteWidth / localWidth;


    }
	
	// Update is called once per frame
	void Update () {

        while (i > 0)
        {

        }
    }

    void DrawAndCount()
    {

        i--;
    }

}
