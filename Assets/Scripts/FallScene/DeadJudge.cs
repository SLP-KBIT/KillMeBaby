using UnityEngine;
using System.Collections;

public class DeadJudge : MonoBehaviour {
	public GameObject sound;

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("floor")) {
			sound.SendMessage("Play");
			Application.LoadLevel ("DeadScene");
		}
	}
}
