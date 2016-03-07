using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;

	private Transform myTransform;

	void Awake(){
		myTransform = transform;
	}


	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");

		target = go.transform;

		maxdistance = 2;
	}


	void Update () { 
		

		if(Vector3.Distance(target.position, myTransform.position) > maxdistance){
			
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}
	}
}