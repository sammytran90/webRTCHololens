using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class Clicker : MonoBehaviour, IInputClickHandler {

    public Button button; 

    public void OnInputClicked(InputClickedEventData eventData)
    {
        button.GetComponent<Button>().onClick.Invoke();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
