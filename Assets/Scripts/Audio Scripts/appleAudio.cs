﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleAudio : MonoBehaviour {

	Vector3 position = new Vector3 ();
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (staticVariables.sequence == 29 ||
			staticVariables.sequence == 31 ||
			staticVariables.sequence == 33) {
			AudioSource.PlayClipAtPoint(clip, position, 2f);
			staticVariables.sequence++;
		}
	}
}
