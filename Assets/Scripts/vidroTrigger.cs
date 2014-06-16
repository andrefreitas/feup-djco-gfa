using UnityEngine;
using System.Collections;

public class vidroTrigger : MonoBehaviour {
	public GameObject vidro;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		vidro = GameObject.Find("vidro");
		vidro.rigidbody.AddForce (Vector3.forward * 1000);
		Progress.UpdatePercentage (35f);
	}
}
