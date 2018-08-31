using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject[] particlePrefabs;
    public int amountOfParticles = 3;
    public float lifetime = 1f;

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < amountOfParticles; i++) {
	        GameObject particlePrefab = Instantiate(particlePrefabs[Random.Range(0, particlePrefabs.Length)]);
	        particlePrefab.transform.position = transform.position;
	    }
	}
	
	// Update is called once per frame
	void Update () {
	    lifetime -= Time.deltaTime;
	    if (lifetime <= 0) {
	        Destroy(gameObject);
	    }
	}
}
