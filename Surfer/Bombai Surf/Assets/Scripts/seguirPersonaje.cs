using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float desp = 2.7f;
	private bool isDead = false;
	private Rigidbody2D rigidbody;
	private int cont = 0;
	private int marc;
	public Text marcador;


	void Start(){
		NotificationCenter.DefaultCenter.AddObserver (this, "PersonajeMuere");
		rigidbody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		if (!isDead) {
			float equis = personaje.position.x;
			transform.position = new Vector3 (equis + desp, transform.position.y, transform.position.z);
			marcador.text = "" + (int) transform.position.x;
		} else {
			rigidbody.velocity = new Vector2(3,0);
		}
	}

	void PersonajeMuere(){
		isDead = true;
		personaje = null;

	}


}
