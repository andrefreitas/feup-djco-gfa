using UnityEngine;
using System.Collections;

public class ElevatorKey : MonoBehaviour {

	public float angSpeed = 1f;
	public bool active = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(active)
			gameObject.transform.Rotate (Vector3.up);
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log ("COLLIDED");
		Destroy (gameObject);
	}
}
