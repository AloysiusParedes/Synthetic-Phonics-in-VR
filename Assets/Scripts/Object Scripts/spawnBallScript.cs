using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBallScript : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
		ball.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		//print (staticVariables.ballInteractions);
		if (staticVariables.sequence >= 13) {
			//print ("SPAWNING BALL");
			ball.active = true;
		}
	}
}
