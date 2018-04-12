using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float desp = 2.7f;

	// Update is called once per frame
	void Update () {

		float equis = personaje.position.x;
		transform.position = new Vector3 (equis + desp, transform.position.y, transform.position.z);
	}
}
