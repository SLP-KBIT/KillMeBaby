﻿using UnityEngine;
using UnityEngine.VR;
using System.Collections;

public class ResetOculus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InputTracking.Recenter();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
