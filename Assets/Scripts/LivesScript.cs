using UnityEngine;
using System.Collections;

public class LivesScript : MonoBehaviour {

	private static int lives = 3;
	public static GameObject textLives;

	// Use this for initialization
	void Start () {
		textLives = GameObject.Find ("Lives_info");
		UpdateTextInfo ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private static void UpdateTextInfo() {
		textLives.gameObject.guiText.text = "Lives: " + lives;
		Debug.Log ("Lives: " + lives);
	}

	public static void IncreaseLives() {
		lives++;
		UpdateTextInfo ();
	}

	// true if ok, false if end
	public static bool DecreaseLives() {
		lives--;
		UpdateTextInfo ();

		if (lives == 0)
			return false;

		return true;
	}

	public static int GetLives() {
		return lives;
	}
}
