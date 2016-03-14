using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float health = 100f;                         
	public float resetAfterDeathTime = 5f;              

	private Animator anim;                              
	private PlayerMovement playerMovement;              
	private HashIDs hash;                               
	private LastPlayerSighting lastPlayerSighting;      
	private float timer;                                
	private bool playerDead;                            


	void setup (){
		
		anim = GetComponent<Animator>();
		playerMovement = GetComponent<PlayerMovement>();
		hash = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<HashIDs>();
		lastPlayerSighting = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<LastPlayerSighting>();
	}


	void Update (){
		if(health <= 0f)
		{
			if(!playerDead)
				PlayerDying();
			else
			{
				PlayerDead();
			}
		}
	}


	void PlayerDying (){
		playerDead = true;

		anim.SetBool(hash.deadBool, playerDead);
	}
		
	void PlayerDead (){
		if(anim.GetCurrentAnimatorStateInfo(0).nameHash == hash.dyingState)
			anim.SetBool(hash.deadBool, false);

		anim.SetFloat(hash.speedFloat, 0f);
		playerMovement.enabled = false;
	}
		

	public void TakeDamage (float amount){
		health -= amount;
	}
}