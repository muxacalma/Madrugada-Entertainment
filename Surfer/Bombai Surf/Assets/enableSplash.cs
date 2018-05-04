using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableSplash : MonoBehaviour {


	public GameObject splash;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.AddObserver (this, "PersonajeMuere");
	}

	void PersonajeMuere(){
		activar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void activar(){
		splash.gameObject.SetActive (true);
	}
}
