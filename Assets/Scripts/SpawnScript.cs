using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnScript : MonoBehaviour {

	public GameObject mytes;
	//need better solution for vumarks than a list; need to be able to determine properties 
	//before using it and be able to call specific ones
	public List<string> VuMarks = new List<string>(); 
	public int spawnLimit = 3;
	private int spawnedCreatures = 0;
	private VuMarkManager vuMgr;

	// Use this for initialization
	void Start () {
		vuMgr = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
		vuMgr.RegisterVuMarkDetectedCallback(onVuMarkDetected);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onVuMarkDetected (VuMarkTarget target){
		Debug.Log (target.InstanceId.StringValue);
		if (target.InstanceId.StringValue == "MY") {
			
			//call function that determines spawn rate and location?
			spawnCreature();
		}
	}

	void spawnCreature () {
		if (spawnedCreatures < spawnLimit) {
			//check IDs to decide probability
			//determine creature spawned from a list per that ID

			//Instantiate(mytes, new Vector3(0,0,0), Quaternion.identity);
			mytes.SetActive (true); 
			spawnedCreatures++;
		}
	}
	void deSpawn () {
		//if existing creatures' time >= whatever time limit
		//despawn creature
		spawnedCreatures--;
	}

}
