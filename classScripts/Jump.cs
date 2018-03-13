using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            OVRPlayerController player = GetComponent<OVRPlayerController>();
            player.Jump();
        }
	}
}
