using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	private bool flag = false;

	// Update is called once per frame
	void Update () {
		if (!flag && Input.GetKey (KeyCode.Return)) {
			transform.position += new Vector3 (0.0f, 1.0f, -2.0f);
			flag = true;
		}
		if (flag && transform.eulerAngles.x < 90.0f) {
			transform.Rotate (new Vector3 (1f, 0f, 0f));
		}
	}
}
