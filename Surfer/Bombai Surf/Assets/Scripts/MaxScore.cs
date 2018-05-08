using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour {

	public EstadoJuego estadojuego;
	public Text maxScore;
	public Text score;

	// Use this for initialization
	void Start () {
		
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		maxScore.text = "RECORD: " + EstadoJuego.estadoJuego.puntuacionMaxima.ToString ();
	}
}
