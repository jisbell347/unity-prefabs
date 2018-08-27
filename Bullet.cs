using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float shootingForce = 2000f;
    public Vector3 shootingDirection;

	// Use this for initialization
	void Start () {
	    GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
