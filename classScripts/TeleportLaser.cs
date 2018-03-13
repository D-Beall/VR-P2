using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLaser : MonoBehaviour {

    public float maxTeleportDistance = 4.0f;

    public float laserThickness = 0.01f;

    private GameObject laser;

	// Use this for initialization
	void Start () {
        laser = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        laser.transform.parent = this.transform;
        laser.transform.localScale = Vector3.zero;
        laser.transform.localPosition = Vector3.zero;
        laser.GetComponent<Renderer>().material.color = Color.red;
        laser.GetComponent<CapsuleCollider>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position, transform.rotation * Vector3.forward * maxTeleportDistance);
        RaycastHit hitInfo;
        //Debug.DrawRay(transform.position, transform.rotation * Vector3.forward * maxTeleportDistance, Color.red, 0f, false);
        bool hit = Physics.Raycast(ray, out hitInfo, maxTeleportDistance);
        float distance = hit ? hitInfo.distance : maxTeleportDistance;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            laser.transform.localScale = new Vector3(laserThickness, laserThickness, distance);
            laser.transform.localPosition = new Vector3(0f, 0f, distance / 2f);

            if (hit && hitInfo.collider.gameObject.layer == LayerMask.NameToLayer("teleportable"))
            {
                transform.position = new Vector3(hitInfo.point.x, 3f, hitInfo.point.z);
            }

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            laser.transform.localScale = Vector3.zero;
            laser.transform.localPosition = Vector3.zero;
        }
	}
}
