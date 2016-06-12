using UnityEngine;
using System.Collections;

public class FallDown : MonoBehaviour {
	public AudioClip windSound;
	public AudioClip laughSound;
	public AudioClip horrorSound;
	private AudioSource audio;
	public GameObject crow;
	private bool fallFlag = false;
	public GameObject target;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio.PlayOneShot (horrorSound);
	}
	
	// Update is called once per frame
	void Update () {
		if (fallFlag) {
			transform.LookAt (target.transform);
		} else {
			// camera→cubeへの単位ベクトルv1
			Vector3 v1 = new Vector3 (
				             crow.transform.position.x - transform.position.x,
				             crow.transform.position.y - transform.position.y,
				             crow.transform.position.z - transform.position.z
			             );
			v1.Normalize ();
			// カメラの正面方向の単位ベクトルv2
			Vector3 v2 = transform.forward;
	
			// 内積を求める
			float dot = Vector3.Dot (v1, v2);
			// 角度差を求める
			float rad = Mathf.Acos (dot);

			// 角度差が一定値以下ならCubeを赤くする
			//Debug.Log(rad);
			//if ( rad < 1.5f ) {
			if (Input.GetKey (KeyCode.Return)) {
				audio.Stop ();
				audio.PlayOneShot (laughSound);
				System.Threading.Thread.Sleep (2500);
				audio.Stop ();
				audio.PlayOneShot (windSound);
				transform.position += new Vector3 (2.0f, 0f, 0f);
				fallFlag = true;
				//transform.LookAt (target.transform);
			}
		}
	}
}
