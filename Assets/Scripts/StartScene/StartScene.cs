using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

	// Use this for initialization
	void Update() {
		if (Input.GetKey (KeyCode.Alpha1)) {
			Application.LoadLevel ("FallScene");
		} else if (Input.GetKey (KeyCode.Alpha2)) {
			Application.LoadLevel ("JumpScene");
		} else if (Input.GetKey (KeyCode.Alpha3)) {
			Application.LoadLevel ("HighJump");
		}
	}
}
