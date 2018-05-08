using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retry : MonoBehaviour {

	public Sprite newsprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		//Debug.Log ("ESTAS CLICKANDO");
			gameObject.GetComponent<SpriteRenderer> ().sprite = newsprite;
			Application.LoadLevel(Application.loadedLevel);
	}


}
