using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float turnSmoothing = 15f;
	public float speedDampTime = 0.1f;

	private Animator anim;
	private HashIDs hash;

	void setup(){
		
		anim = GetComponent<Animator> ();
		hash = GameObject.FindGameObjectWithTag (Tags.gameController).GetComponent<HashIDs> ();

	}
		
	void FixedUpdate(){
		
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		bool sneak = Input.GetButton ("Sneak");

		MovementManagment (h, v, sneak);
	}

	void MovementManagment(float horizontal, float vertical, bool sneaking){ 

		anim.SetBool (hash.sneakingBool, sneaking);

		if (horizontal != 0f || vertical != 0f){
			anim.SetFloat (hash.speedFloat, 5.5f, speedDampTime, Time.deltaTime);
				
		} else {
			anim.SetFloat (hash.speedFloat, 0f);
		}

	}
}
