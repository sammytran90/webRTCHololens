using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour {
    public Text posX;
    public Text posY;
    public Text posZ;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        posX.text = this.gameObject.transform.position.x.ToString();
        posY.text = this.gameObject.transform.position.y.ToString();
        posZ.text = this.gameObject.transform.position.z.ToString();
    }
}
