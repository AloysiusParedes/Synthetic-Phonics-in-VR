using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepScript : MonoBehaviour {
	public float speedOfStep = 60;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		//print (transform.rotation.ToString());

		if (transform.rotation.x >= 0.2 && speedOfStep > 0) 
			speedOfStep *= -1;
		
		else if (transform.rotation.x <= 0.0 && speedOfStep < 0) 
			speedOfStep *= -1;
		


		//rotate pivot about x-axis
		transform.Rotate(new Vector3(Time.deltaTime * speedOfStep, 0f, 0f));


	}
}
