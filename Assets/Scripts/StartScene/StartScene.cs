using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

	// Use this for initialization
	void Update() {
		if (Input.GetKey(KeyCode.Return))
			Application.LoadLevel ("FallScene");
	}
}
