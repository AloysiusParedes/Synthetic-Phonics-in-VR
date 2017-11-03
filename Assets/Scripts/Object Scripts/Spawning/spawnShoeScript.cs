using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnShoeScript : MonoBehaviour {

	public GameObject shoe;

	// Use this for initialization
	void Start () {
		shoe.active = false;
	}

	// Update is called once per frame
	void Update () {
		//print (staticVariables.ballInteractions);
		if (staticVariables.sequence == 25) {
			//print ("SPAWNING BALL");
			shoe.active = true;
		}
	}
}
