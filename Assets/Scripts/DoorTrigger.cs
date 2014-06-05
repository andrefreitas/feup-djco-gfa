using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public GameObject door;
	public GameObject doorSwitch;
	public long maxCycles = 600;
	public long cycles = 0;
	private bool pressed = false;
	public float angularVel = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (pressed) {

			door.transform.Rotate(Vector3.up * (-angularVel));

			if(cycles < maxCycles) {
				Debug.Log(cycles);
				cycles++;
			}

			else pressed = false;
		}
	
	}

	void OnTriggerEnter(Collider other) {
		cycles = 0;
		pressed = true;
	}
}
