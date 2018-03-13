using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTarget : MonoBehaviour {
    private Transform cam;

	// Use this for initialization
	void Start () {
        cam = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        ray = new Ray(cam.position, cam.rotation * Vector3.forward);
        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if (hitObject == this.gameObject)
            {
                Debug.Log("Able to teleport");
                GetComponent<Renderer>().material.color = Color.blue;
                if (Clicker.clicked)
                {
                    GameObject fsm = GameObject.FindGameObjectWithTag("Player");
                    fsm.transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
                }
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.white;
            }

            
        }
	}
}
