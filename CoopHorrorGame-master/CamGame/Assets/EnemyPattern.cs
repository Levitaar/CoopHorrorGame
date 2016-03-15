using UnityEngine;
using System.Collections;

public class EnemyPattern : MonoBehaviour {

	public bool ToA;
	public bool IsPlayerDead;
	public bool InSight;
	public bool lerping;

	public float patrolSpeed;
	public float chaseSpeed = 5f;

	public GameObject WaypointA;
	public GameObject WaypointB;
	public GameObject player;
	private Vector3 startpoint;
	private Vector3 endpoint;

	private int direction;

	void Start() {

		startpoint = WaypointA.transform.position;
		endpoint = WaypointB.transform.position;
		InSight = false;
		transform.position = startpoint;

	}

	void Update() {


		if (InSight == true) {
			lerping = false;

			print ("I SEE DEAD PEOPLE");

			transform.position = Vector3.MoveTowards (transform.position, player.transform.position, Time.deltaTime * chaseSpeed);
			transform.LookAt (player.transform.position);

		} 

		if (InSight == false) {

			print ("CANT SEE");

			if (transform.position == startpoint) {
				print ("TO END POINT");
				ToA = true;

			}

			if (transform.position == endpoint) {
				print ("TO START POINT");
				ToA = false;

			}

			if (ToA) {
				transform.position = Vector3.MoveTowards (transform.position, endpoint, Time.deltaTime * patrolSpeed);
				transform.LookAt (WaypointB.transform.position);

			} else {
				transform.position = Vector3.MoveTowards (transform.position, startpoint, Time.deltaTime * patrolSpeed);
				transform.LookAt (WaypointA.transform.position);

			}
		}
	} 

	void OnTriggerStay(Collider other) {

		if (other.gameObject.name == "TestDummy") {

			InSight = true;

		}

	}

	void OnTriggerExit(Collider other) {

		if (other.gameObject.name == "TestDummy") {

			InSight = false;

		}

	}
}
