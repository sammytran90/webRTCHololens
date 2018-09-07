using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class textScript : MonoBehaviour {

    public GameObject cursor;
    public GameObject pen;
    public TextMesh textMesh;
    // Use this for initialization

    public void drawTest()
    {
        textMesh.text = "start";
        var objects = GameObject.FindGameObjectsWithTag("pen");
        Debug.Log("object length: " + objects.Length);
        if (objects.Length == 0)
        {
            try
            {
                appendPen();
            }
            catch (Exception ex)
            {
                Debug.LogException(ex, this);
            }
        }
        else
        {
            try
            {
                destroyPen();
                appendPen();
            }
            catch (Exception ex)
            {
                Debug.LogException(ex, this);
            }
        }
    }

    public void endDrawTest()
    {
        textMesh.text = "end";
        try
        {
            destroyPen();
        }
        catch (Exception ex)
        {
            Debug.LogException(ex, this);
        }
    }

    public void detroyAllInk()
    {
        try
        {
            var objects = GameObject.FindGameObjectsWithTag("ink");
            foreach (var obj in objects)
            {
                Destroy(obj);
            }
        }
        catch (Exception ex)
        {
            Debug.LogException(ex, this);
        }

    }

    private void appendPen()
    {
        Vector3 p = new Vector3(cursor.transform.position.x, cursor.transform.position.y, cursor.transform.position.z);
        Quaternion rot = Camera.main.transform.rotation;
        //Instantiate(pen, p, Quaternion.identity);
        Instantiate(pen, p, rot);
    }

    private void destroyPen()
    {
        var objects = GameObject.FindGameObjectsWithTag("pen");
        foreach (var obj in objects)
        {
            var childObj = obj.transform.GetChild(0).gameObject;
            Destroy(childObj.GetComponent<RelativePosition>());
            obj.transform.DetachChildren();
            Destroy(obj);
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
