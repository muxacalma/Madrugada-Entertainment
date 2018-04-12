using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

	public GameObject[] objetos;
	public float tiempoMin = 1f;
	public float tiempoMax = 2f;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter.AddObserver(this, "PersonajeEmpiezaASurfear");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PersonajeEmpiezaASurfear(){
		Generar ();
	}

	void Generar(){
		Instantiate(objetos[Random.Range(0, objetos.Length)], transform.position, Quaternion.identity);
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));

	}
}
