using UnityEngine;
using System.Collections;

public class fallCubeTrigger : MonoBehaviour {
	public GameObject fallCube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		fallCube = GameObject.Find("fallCube");
		fallCube.rigidbody.AddForce (Vector3.forward * 1000);
		Debug.Log ("Detetou colisao");
	}
}
