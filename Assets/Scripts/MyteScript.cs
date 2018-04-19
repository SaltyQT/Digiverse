using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyteScript : MonoBehaviour {

	//Use this script for:
	//Creature movement
	//Specific identifiers
	//Database info

	private Vector3 vel;
	private float timer;
	private int sec;

	// Use this for initialization
	void Start () {
		ResetVel ();
		ResetSec ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > sec) {
			ResetVel ();
			ResetSec ();
		}
	}

	void ResetVel() {
		vel.Set(Random.Range (-2.0f, 2.0f), Random.Range (-2.0f, 2.0f), Random.Range (-2.0f, 2.0f));
	}

	void ResetSec() {
		timer = 0;
		sec = Random.Range (1, 3);
	}



}
