using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swayScript : MonoBehaviour {
	public float speedOfSway = 60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (transform.rotation.ToString());


		if (transform.rotation.z >= 0.1 && speedOfSway > 0) 
			speedOfSway *= -1;
		
		else if (transform.rotation.z <= -0.0 && speedOfSway < 0) 
			speedOfSway *= -1;
		


		//rotate pivot about x-axis
		transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * speedOfSway));
	}
}
