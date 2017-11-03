using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionsAudio : MonoBehaviour {

	Vector3 position = new Vector3 ();
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (staticVariables.sequence == 3) {
			AudioSource.PlayClipAtPoint(clip, position);
			staticVariables.sequence++;
		}
	}
}
