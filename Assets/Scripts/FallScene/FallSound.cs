using UnityEngine;
using System.Collections;

public class FallSound : MonoBehaviour {
	private AudioSource audio;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		audio = GetComponent<AudioSource> ();
	}

	public void Play () {
		audio.PlayOneShot (audio.clip);
	}
}
