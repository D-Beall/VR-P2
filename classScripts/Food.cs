using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
    public Transform player;
    

    // Use this for initialization
    void Start () {
      
	}
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject == player)
        {
            Destroy(self.gameObject);

        }
    }

    // Update is called once per frame
    void Update ()
    {
       
    }
}
