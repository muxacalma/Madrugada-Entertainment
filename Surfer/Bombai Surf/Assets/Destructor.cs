using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		Destroy (collision.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
	}
}
