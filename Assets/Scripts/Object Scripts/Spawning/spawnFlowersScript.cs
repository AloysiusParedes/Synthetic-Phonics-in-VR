using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFlowersScript : MonoBehaviour {

	public GameObject flowers;

	// Use this for initialization
	void Start () {
		flowers.active = false;
	}

	// Update is called once per frame
	void Update () {
		//print (staticVariables.ballInteractions);
		if (staticVariables.sequence == 55) {
			//print ("SPAWNING BALL");
			flowers.active = true;
		}
	}
}
