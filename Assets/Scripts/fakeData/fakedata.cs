using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakedata : MonoBehaviour {

    Vector2[] arr = new Vector2[] { };
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 5; i++) {
            Vector2 elem = new Vector2(i+1, i+1);
            arr[i] = elem;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
