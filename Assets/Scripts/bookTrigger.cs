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
		gameScript.updateMessage("Encontra o livro que viste na pista que demos...");
		GameObject.Find ("particlesBook").particleSystem.emissionRate = 0;
		bookFound = false;
		goalAudio = GameObject.Find ("goalAudio");
		
	}

	void OnTriggerEnter(Collider col) {
		bookText = GameObject.Find ("bookText");
		if (!bookFound) {
			gameScript.updateMessage("Agora que encontraste o livro, tens que encontrar a chave para o abrir!");
			if(percBookFound) {
				Progress.IncreasePercentage(40f);
				percBookFound = false;
			}
		} else {
			goalAudio.audio.Play();
			bookFisica = GameObject.Find ("bookFisica");
			Destroy(bookFisica);
			GameObject.Find ("particlesBook").particleSystem.emissionRate = 10;
			gameScript.updateMessage("Conseguiste abrir o livro!");
			Progress.UpdatePercentage(100f);
			Destroy (gameObject);
		}
	}

}