using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		NotificationCenter.DefaultCenter.AddObserver (this, "PersonajeMuere");
	}

	void PersonajeMuere() {
		Activar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Activar(){
		gameObject.SetActive (true);
	}
}
