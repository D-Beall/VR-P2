using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshairs : MonoBehaviour {

    public float size = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        float w = Camera.main.pixelWidth;
        float h = Camera.main.pixelHeight;
        GUI.Label(new Rect(w / 2 - size/2, h / 2 - size/2, size, size), "+");
    }
}
