using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEfectoOla : MonoBehaviour {

	public float velocidad = 0f;
	private bool empezar = true;
	private float tiempoInicio = 0f;

	// Use this for initialization
	void Start () {
		//NotificationCenter.DefaultCenter.AddObserver (this, "PersonajeEmpiezaASurfear");
	}

	void PersonajeEmpiezaASurfear(){
		empezar = true;
		tiempoInicio = Time.time;
	}

	// Update is called once per frame
	void Update () {
		if (empezar) {
			gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (((Time.time - tiempoInicio) * velocidad) % 1, ((Time.time - tiempoInicio) * velocidad) % 1);

		}
	}
}
