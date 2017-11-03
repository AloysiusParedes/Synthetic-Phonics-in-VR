using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBookScript : MonoBehaviour {

	public GameObject book;

	// Use this for initialization
	void Start () {
		book.active = false;
	}

	// Update is called once per frame
	void Update () {
		//print (staticVariables.ballInteractions);
		if (staticVariables.sequence == 45) {
			//print ("SPAWNING BALL");
			book.active = true;
		}
	}
}
