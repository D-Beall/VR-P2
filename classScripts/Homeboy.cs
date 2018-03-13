using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homeboy : MonoBehaviour {

    public float fallDepth = -5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Have we fallen?
        if (transform.position.y < fallDepth)
        {
            transform.position = new Vector3(0, 0, 0);
        }
	}
}
