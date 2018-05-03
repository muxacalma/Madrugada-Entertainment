﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetosColision : MonoBehaviour {

	public GameObject splash;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player") {
			NotificationCenter.DefaultCenter.PostNotification (this, "PersonajeMuere");
			Destroy (collision.gameObject);
			splash.gameObject.SetActive (true);
		}
	}
}
