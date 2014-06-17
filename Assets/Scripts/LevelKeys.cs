using UnityEngine;
using System.Collections;

public class LevelKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Progress.UpdatePercentage (0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("intro");
		} else if (Input.GetKey (KeyCode.F1)) {
			if(LivesScript.DecreaseLives())
				Application.LoadLevel (Application.loadedLevel);

			else Application.LoadLevel ("intro");
		}
	}
}
