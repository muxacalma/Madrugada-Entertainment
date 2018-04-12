using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour {

	public GameObject g;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("aqui llega");
		StartCoroutine(DelayedAnimation());
	}

	// The delay coroutine
	IEnumerator DelayedAnimation ()
	{
		Debug.Log ("y aqui");
		yield return new WaitForSeconds(1f);
		g.SetActive (true);
	}

}