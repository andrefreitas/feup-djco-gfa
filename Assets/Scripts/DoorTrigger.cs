using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public GameObject door;
	public GameObject doorSwitch;
	public long maxCycles = 600;
	public long cycles = 0;
	private bool pressed = false;
	public float angularVel = 0.5f;
	public float incYButton = 0.001f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (pressed) {

			door.transform.Rotate(Vector3.up * (-angularVel));

			if(cycles < maxCycles) {
				cycles++;
			}

			else {
				SetSwitchOff();
			}
		}
	
	}

	void OnTriggerEnter(Collider col) {
		cycles = 0;
		SetSwitchOn();
	}

	void SetSwitchOn() {
		if (!pressed) {
			for (int i = 0; i < 100; i++) {
					doorSwitch.transform.Translate (Vector3.down * incYButton);
			}

			pressed = true;
		}
	}

	void SetSwitchOff() {
		for (int i = 0; i < 100; i++) {
			doorSwitch.transform.Translate(Vector3.up*incYButton);
		}

		pressed = false;
	}
}
