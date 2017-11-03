using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayWithTheBall : MonoBehaviour {

	public GameObject play, with, the, ball;

	// Use this for initialization
	void Start () {
		play.active = false;
		with.active = false;
		the.active = false;
		ball.active = false;
	}

	// Update is called once per frame
	void Update () {
		print (staticVariables.sequence);
		if (staticVariables.sequence == 7) {
			//print ("SPAWNING BALL");
			play.active = true;
			with.active = true;
			the.active = true;
			ball.active = true;
			staticVariables.sequence++;
		}
	}
}
