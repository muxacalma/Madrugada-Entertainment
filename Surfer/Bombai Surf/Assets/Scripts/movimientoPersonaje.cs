using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonaje : MonoBehaviour {

	public float velocidad, fuerzaSalto;

	private bool surf = false;

	private Rigidbody2D rigidbody;
	private Animator animator;
	private bool salta = false;
	static int jumpingState = Animator.StringToHash("Jumping");  
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		salta = false;
		animator.SetBool ("queSalte", salta);
		//this.gameObject.GetComponent<Collider2D>().transform.position = this.gameObject.GetComponent<Collider2D>().transform.position + new Vector3(0, 0.32f, 0);
		if (Input.GetMouseButtonDown (0)) {
			if (surf) {
				//Hacemos que salte
				rigidbody.velocity = new Vector2(velocidad, 0);
				rigidbody.AddForce(new Vector2(0, fuerzaSalto));
				salta = true;
				animator.SetBool ("queSalte", salta);
				//int currentBaseState = animator.GetCurrentAnimatorStateInfo(0);
				if (animator.GetCurrentAnimatorStateInfo(0).IsName("Jumping")) {
					animator.SetBool ("vuelveASaltar", true);
				}
				if (animator.GetCurrentAnimatorStateInfo(0).IsName("SegundoJumping")) {
					animator.SetBool ("vuelveASaltar", false);
				}



			} else {
				surf = true;
				rigidbody.isKinematic = false;
				NotificationCenter.DefaultCenter.PostNotification (this, "PersonajeEmpiezaASurfear");
			}
		}
	}

	void FixedUpdate(){
		if (surf) {
			rigidbody.velocity = new Vector2 (velocidad, rigidbody.velocity.y);
		}
	}
}
