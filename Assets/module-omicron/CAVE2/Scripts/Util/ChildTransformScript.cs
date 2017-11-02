﻿using UnityEngine;
using System.Collections;

public class ChildTransformScript : MonoBehaviour {

	public Transform parent;
	public bool matchPosition = true;
	public bool matchRotation = true;
	public bool matchScale = true;

	Vector3 positionOffset;
	Vector3 rotationOffset;
	Vector3 scaleOffset;

	public bool useLateUpdate = false;
    public bool useOffset = true;
	// Use this for initialization
	void Start () {
		positionOffset = transform.position;
		rotationOffset = transform.eulerAngles;
		scaleOffset = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if( !useLateUpdate )
		{
            UpdateTransform();
        }
	}

	void LateUpdate () {
		if( useLateUpdate )
		{
            UpdateTransform();

        }
	}

    void UpdateTransform()
    {
        int offset = 1;
        if (!useOffset)
            offset = 0;

        if (parent && matchPosition)
            transform.position = parent.position + positionOffset * offset;
        if (parent && matchRotation)
            transform.eulerAngles = parent.eulerAngles + rotationOffset * offset;
        if (parent && matchScale)
            transform.localScale = parent.localScale + scaleOffset * offset;
    }
}
