using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeAudio : MonoBehaviour {

	Vector3 position = new Vector3 ();
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (staticVariables.sequence == 59 ||
			staticVariables.sequence == 61 ||
			staticVariables.sequence == 63) {
			AudioSource.PlayClipAtPoint(clip, position, 2f);
			staticVariables.sequence++;
		}
	}
}
