using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //Make sure a rigidbody is attached to the falling object

public class fallingScript : MonoBehaviour {
	public Transform player; //This creates a slot in the inspector where you can add your player
	public float maxDistance = 5f; //This can be changed in the inspector to your liking
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		//transform is the object that this script is attached to
		if (Vector3.Distance (player.position, transform.position) < maxDistance) { 
			rigidbody.useGravity = true;
		}
	}
}
