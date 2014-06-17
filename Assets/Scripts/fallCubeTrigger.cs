using UnityEngine;
using System.Collections;

public class fallCubeTrigger : MonoBehaviour {
	public GameObject fallCube;
	public GameObject stoneAudio;
	public bool fall;
	// Use this for initialization
	void Start () {
		fall = false;
		stoneAudio = GameObject.Find ("stoneAudio");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (!fall) {
			fall = true;
			stoneAudio.audio.Play ();
		}

		fallCube = GameObject.Find("fallCube");
		fallCube.renderer.enabled = true;
		fallCube.rigidbody.isKinematic = false;
		fallCube.rigidbody.useGravity = true;
	}
}
