using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    //포탄의 속도
    public float speed = 6000.0f;
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
	}
	

	void Update () {
		
	}
}
