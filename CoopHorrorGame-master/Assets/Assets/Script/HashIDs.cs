using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {

	public int dyingState;
	public int locomotionState;
	public int deadBool;
	public int speedFloat;
	public int sneakingBool;
	public int playerInSightBool;


	void setup ()
	{
		dyingState = Animator.StringToHash("Base Layer.Dying");
		locomotionState = Animator.StringToHash("Base Layer.Locomotion");
		deadBool = Animator.StringToHash("Dead");
		speedFloat = Animator.StringToHash("Speed");
		sneakingBool = Animator.StringToHash("Sneaking");
		playerInSightBool = Animator.StringToHash("PlayerInSight");
	}
}