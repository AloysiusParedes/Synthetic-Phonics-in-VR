using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFindTheFlower : MonoBehaviour {

	public GameObject find, the, flower;

	// Use this for initialization
	void Start () {
		find.active = false;
		the.active = false;
		flower.active = false;
	}

	// Update is called once per frame
	void Update () {
		print (staticVariables.sequence);
		if (staticVariables.sequence == 47) {
			//print ("SPAWNING BALL");
			find.active = true;
			the.active = true;
			flower.active = true;
		}
	}
}
