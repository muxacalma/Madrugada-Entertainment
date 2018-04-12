using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocidaddecoracion : MonoBehaviour {

	private Rigidbody2D rigidbody;
	public float velocidad = 2f;

	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.velocity = new Vector2(velocidad, 0);
		
	}
}
