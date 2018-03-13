using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    private ParticleSystem particles;

    // Use this for initialization
    void Start () {
        GameObject ps = GameObject.FindGameObjectWithTag("Explosion");
        particles = ps.GetComponent<ParticleSystem>();
        particles.Stop();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Die()
    {
        Wanderer wanderer = GetComponent<Wanderer>();
        if (wanderer != null)
        {
            wanderer.Alive = false;
        }
        Stalker stalker = GetComponent<Stalker>();
        if(stalker != null)
        {
            stalker.Alive = false;
        }

        particles.transform.position = transform.position;
        particles.Play();
        StartCoroutine(DramaticDeath());
    }

    protected IEnumerator DramaticDeath()
    {
        for (int i = 0; i < 20; i++)
        {
            transform.Rotate(10f, 0f, 10f);
            yield return new WaitForSeconds(0.1f);
        }

        particles.Stop();
        Destroy(gameObject);
    }
}
