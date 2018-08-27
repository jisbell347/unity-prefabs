using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float shootingForce = 2000f;

	// Use this for initialization
	void Start () {
	    GetComponent<Rigidbody>().AddForce(Vector3.forward * shootingForce);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
