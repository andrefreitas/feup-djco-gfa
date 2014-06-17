using UnityEngine;
using System.Collections;

public class piso1Key : MonoBehaviour {

	public float angSpeed = 1f;
	public GameObject keyAudio;
	// Use this for initialization
	void Start () {

		keyAudio = GameObject.Find ("keyAudio");
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (Vector3.up);
	}

	void OnTriggerEnter(Collider col) {
		keyAudio.audio.Play ();
		Debug.Log ("Found the key!");
		bookTrigger.bookFound = true;
		Progress.IncreasePercentage (25f);
		Destroy (gameObject);
	}
}
