using UnityEngine;
using System.Collections;


public class bookTrigger : MonoBehaviour {

	// Use this for initialization
	public static bool bookFound;
	public GameObject bookText;
	public GameObject bookFisica;
	public bool percBookFound = true;
	public GameObject goalAudio;
	// Use this for initialization
	void Start () {
		GameObject.Find ("particlesBook").particleSystem.emissionRate = 0;
		bookFound = false;
		goalAudio = GameObject.Find ("goalAudio");
		
	}

	void OnTriggerEnter(Collider col) {
		bookText = GameObject.Find ("bookText");
		if (!bookFound) {
			bookText.guiText.enabled = true;
			if(percBookFound) {
				Progress.IncreasePercentage(40f);
				percBookFound = false;
			}
		} else {
			goalAudio.audio.Play();
			bookText.guiText.enabled = true;
			bookFisica = GameObject.Find ("bookFisica");
			Destroy(bookFisica);
			GameObject.Find ("particlesBook").particleSystem.emissionRate = 10;
			bookText.guiText.text = "Encontraste!";
			Progress.UpdatePercentage(100f);
			Destroy (gameObject);
		}
	}

}