using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MouseCoord : MonoBehaviour {
    private Text mouseCoord;
	// Use this for initialization
	void Start () {
        mouseCoord = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
      mouseCoord.text = "Mouse X: " + Input.mousePosition.x.ToString()+ " Mouse Y: " + Input.mousePosition.y.ToString();
	}
}
