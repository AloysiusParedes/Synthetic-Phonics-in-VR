using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnHomeScript : MonoBehaviour {

	public GameObject home;

	// Use this for initialization
	void Start () {
		home.active = false;
	}

	// Update is called once per frame
	void Update () {
		//print (staticVariables.ballInteractions);
		if (staticVariables.sequence == 65) {
			//print ("SPAWNING BALL");
			home.active = true;
		}
	}
}
