using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour {
    public GameObject floor;
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

        ray =  new Ray(cam.position, cam.rotation * Vector3.forward);
        if(Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if(hitObject == floor)
            {
                transform.position = hit.point;
            }
        }
	}
}
