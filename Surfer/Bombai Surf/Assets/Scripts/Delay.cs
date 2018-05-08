using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delay : MonoBehaviour {

	public Text marcador;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("aqui llega");
		StartCoroutine(DelayedAnimation());
		NotificationCenter.DefaultCenter.AddObserver (this, "PersonajeEmpiezaASurfear");
	}

	// The delay coroutine
	IEnumerator DelayedAnimation ()
	{
		Debug.Log ("y aqui");
		yield return new WaitForSeconds(1f);
	}

	void PersonajeEmpiezaASurfear(){
		gameObject.SetActive (false);

	}

}