using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float turnSmoothing = 15f;
	public float speedDampTime = 0.1f;
	public float speed;

	private Animator anim;
	private HashIDs hash;

	void Awake(){
		anim = GetComponent<Animator> ();
		hash = GameOnject.FindGameObjectWithTag (Tags.gameController).GetComponent<HashIDs> ();
	}


	void FixedUpdate(){
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		bool sneak = Input.GetButton ("Sneak");

		MovementManagement (h, v, sneak);
	}

	void MovementManagment(float horizontal, float vertical, bool sneaking){ 
		anim.SetBool (hash.sneakingBool, sneaking);
		if (horizontal != 0f || vertical != 0f) {
			Rotating(horizontal, vertical);
			SetFloat (speed = 5.5f, speedDampTime, Time.deltaTime);
				
		} else {
			speed = 0f
		}

	}
		
	void Rotating(float horizontal, float vertical){
		Vector3 tragetDirection = new Vector3 (horizontal, 0f, vertical);
		Quaternion targetRotation = Quaternion.LookRotation (targetDirection, Vector3.up);
		Quaternion newRotation = Quaternion.Lerp (rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);
		rigidbody.MoveRotation (newRotation);
	}
