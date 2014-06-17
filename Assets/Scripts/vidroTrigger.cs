using UnityEngine;
using System.Collections;

public class vidroTrigger : MonoBehaviour {
	public GameObject vidro;
	public GameObject windowAudio;
	// Use this for initialization
	void Start () {
		windowAudio = GameObject.Find ("windowAudio");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		vidro = GameObject.Find("vidro");
		windowAudio.audio.Play ();
		vidro.rigidbody.AddForce (Vector3.forward * 1000);
		Progress.UpdatePercentage (35f);
	}
}
