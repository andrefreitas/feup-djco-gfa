using UnityEngine;
using System.Collections;

public class ElevatorKey : MonoBehaviour {
	
	public float angSpeed = 1f;
	public GameObject elevatorDoor;
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
		Debug.Log ("COLLIDED");
		Destroy (gameObject);
		Destroy (elevatorDoor);
		StairsDoorTrigger.SetKeyState (true);
		Progress.UpdatePercentage (75);
	}
}
