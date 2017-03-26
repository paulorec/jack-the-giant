using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed, maxVelocity;

	[SerializeField]
	private Rigidbody2D rigidBody;
	private Animator animator;

	void Awake() {

		rigidBody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMoveKeyboard ();
	}

	void PlayerMoveKeyboard() {
		
		float forceX = 0f, 
		vel = Mathf.Abs (rigidBody.velocity.x),
		h = Input.GetAxisRaw ("Horizontal");

		Debug.Log ("h is " + h);

		if (h > 0) {

			if (vel < maxVelocity)
				forceX = speed;

			animator.SetBool ("walk", true);
			Vector3 temp = this.transform.localScale;

			temp.x = 1.3f;
			this.transform.localScale = temp;

		} else if (h < 0) {
			
			if (vel < maxVelocity)
				forceX = -speed;

			animator.SetBool ("walk", true);

			Vector3 temp = this.transform.localScale;

			temp.x = -1.3f;

			this.transform.localScale = temp;

		} else if(vel == 0) {
			
			animator.SetBool ("walk", false);
		}

		rigidBody.AddForce (new Vector2(forceX, 0));
	}
}
