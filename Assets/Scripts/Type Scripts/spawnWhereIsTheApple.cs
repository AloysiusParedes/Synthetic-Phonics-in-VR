using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWhereIsTheApple : MonoBehaviour {

	public GameObject where1, is1, the, apple;

	// Use this for initialization
	void Start () {
		where1.active = false;
		is1.active = false;
		the.active = false;
		apple.active = false;
	}

	// Update is called once per frame
	void Update () {
		print (staticVariables.sequence);
		if (staticVariables.sequence == 27) {
			//print ("SPAWNING BALL");
			where1.active = true;
			is1.active = true;
			the.active = true;
			apple.active = true;
		}
	}
}
