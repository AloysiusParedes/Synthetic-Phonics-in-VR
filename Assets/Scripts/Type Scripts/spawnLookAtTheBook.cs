using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLookAtTheBook : MonoBehaviour {

	public GameObject look, at, the, book;

	// Use this for initialization
	void Start () {
		look.active = false;
		at.active = false;
		the.active = false;
		book.active = false;
	}

	// Update is called once per frame
	void Update () {
		print (staticVariables.sequence);
		if (staticVariables.sequence == 37) {
			//print ("SPAWNING BALL");
			look.active = true;
			at.active = true;
			the.active = true;
			book.active = true;
			staticVariables.sequence++;
		}
	}
}
