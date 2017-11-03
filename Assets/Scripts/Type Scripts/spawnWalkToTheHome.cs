using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWalkToTheHome : MonoBehaviour {

	public GameObject walk, to, the, home;

	// Use this for initialization
	void Start () {
		walk.active = false;
		to.active = false;
		the.active = false;
		home.active = false;
	}

	// Update is called once per frame
	void Update () {
		print (staticVariables.sequence);
		if (staticVariables.sequence == 57) {
			//print ("SPAWNING BALL");
			walk.active = true;
			to.active = true;
			the.active = true;
			home.active = true;
			staticVariables.sequence++;
		}
	}
}
