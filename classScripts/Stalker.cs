using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalker : MonoBehaviour {
    public float speed = 1.0f;
    public Transform Player;
    public float obstacleRange = 0.5f;

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
            transform.LookAt(Player);
            if (Vector3.Distance(transform.position, Player.position) >= obstacleRange)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }
   
	}
}
