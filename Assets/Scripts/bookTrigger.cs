using UnityEngine;
using System.Collections;


public class bookTrigger : MonoBehaviour {

	// Use this for initialization
	public static bool bookFound;
	public GameObject bookText;

	// Use this for initialization
	void Start () {
		bookFound = false;
		
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log ("Book found: " + bookTrigger.bookFound);
		bookText = GameObject.Find ("bookText");
		if (!bookFound) {
			bookText.guiText.enabled = true;
		} else {
			bookText.guiText.enabled = true;
			bookText.guiText.text = "Encontraste!";
		}
	}

}