using UnityEngine;
using System.Collections;

public class domino : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log ("forca");
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce(transform.forward * 10,ForceMode.Impulse);
	}
}
