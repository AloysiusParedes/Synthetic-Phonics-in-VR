using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAppleScript : MonoBehaviour {
	public GameObject apple;

	// Use this for initialization
	void Start () {
		apple.active = false;
	}

	// Update is called once per frame
	void Update () {
		//print (staticVariables.ballInteractions);
		if (staticVariables.sequence == 35) {
			//print ("SPAWNING BALL");
			apple.active = true;
		}
	}
}
