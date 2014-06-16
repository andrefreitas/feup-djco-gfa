using UnityEngine;
using System.Collections;

public class StairsDoorTrigger : MonoBehaviour {

	public GameObject stairsDoor;
	private static bool hasKey = true;
	private bool nearDoor = false;
	private long timeElapsed = 0;
	private long limitTime = 300;
	private bool rotatingDoor = false;
	private long cyclesDoor = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("k") && hasKey && nearDoor) {
			//Destroy (stairsDoor);
			rotatingDoor = true;
			hasKey = false;
		}

		if (nearDoor) {
			timeElapsed++;

			if(timeElapsed >= limitTime) {
				nearDoor = false;
				timeElapsed = 0;
			}
		}

		if (rotatingDoor) {
			cyclesDoor++;
			stairsDoor.transform.Rotate(Vector3.up * 1f);
			if(cyclesDoor >= 85) {
				rotatingDoor = false;
			}
		}
	}

	void OnTriggerEnter(Collider col) {
		nearDoor = true;
	}

	public static void SetKeyState(bool state) {
		hasKey = state;
	}
}
