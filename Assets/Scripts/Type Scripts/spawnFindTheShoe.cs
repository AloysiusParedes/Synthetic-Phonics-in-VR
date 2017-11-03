using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFindTheShoe : MonoBehaviour {

	public GameObject find, the, shoe;

	// Use this for initialization
	void Start () {
		find.active = false;
		the.active = false;
		shoe.active = false;
	}

	// Update is called once per frame
	void Update () {
		print (staticVariables.sequence);
		if (staticVariables.sequence == 17) {
			//print ("SPAWNING BALL");
			find.active = true;
			the.active = true;
			shoe.active = true;
			staticVariables.sequence++;
		}
	}
}
