using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativePosition : MonoBehaviour {
    public GameObject gameObject;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = gameObject.transform.position + offset;
	}
}
