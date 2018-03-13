using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject cobject = collision.collider.gameObject;
        Pickable picked = cobject.GetComponent<Pickable>();
        if (picked != null)
        {
            picked.transform.parent = this.transform;
            //picked.transform.position = new Vector3(0, 0, -0.5f);
        }
    }
}
