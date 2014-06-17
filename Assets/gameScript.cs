using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	public static string message = "Arranja uma maneira de entrar dentro da Biblioteca";
	public static GameObject GameSound;

	// Use this for initialization
	void Start () {
		gameScript.GameSound = GameObject.Find ("GameSound");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		// Make a background box
		GUI.Box (new Rect (Screen.width - 800,50,500,25), gameScript.message);

	}

	public static void updateMessage(string msg){
		gameScript.GameSound = GameObject.Find ("GameSound");
		gameScript.GameSound.audio.Play ();
		gameScript.message = msg;
	}
}
