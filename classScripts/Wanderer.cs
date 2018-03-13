using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : MonoBehaviour {
    public float speed = 6.0f;
    public float obstacleRange = 5.0f;

    private float rayRadius = 0.75f;

    private bool _alive = true;
    public bool Alive
    {
        get
        {
            return _alive;
        }

        set
        {
            _alive = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, rayRadius, out hit))
            {
                if (hit.distance < obstacleRange)
                {
                    // Rotate in a pseudo-random motion.
                    float angle = Random.Range(-120, 120);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
	}
}
