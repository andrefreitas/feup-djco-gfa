using UnityEngine;
using System.Collections;


public class bookTrigger : MonoBehaviour {

	// Use this for initialization
	public static bool bookFound;
	public GameObject bookText;
	public GameObject bookFisica;

	// Use this for initialization
	void Start () {
		GameObject.Find ("particlesBook").particleSystem.emissionRate = 0;
		bookFound = false;
		
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log ("Book found: " + bookTrigger.bookFound);
		bookText = GameObject.Find ("bookText");
		if (!bookFound) {
			bookText.guiText.enabled = true;
		} else {
			bookText.guiText.enabled = true;
			bookFisica = GameObject.Find ("bookFisica");
			Destroy(bookFisica);
			GameObject.Find ("particlesBook").particleSystem.emissionRate = 10;
			bookText.guiText.text = "Encontraste!";

		}
	}

}