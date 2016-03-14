using UnityEngine;
using System.Collections;

public class EnemyPattern : MonoBehaviour {

	public bool IsPlayerDead;
	public bool InSight;
	public float patrolSpeed = 3f;
	public float chaseSpeed = 5f;
	public bool direction;
	public GameObject WaypointA;
	public GameObject WaypointB;
	public Transform player;


	void Setup() {

		InSight = false;
		gameObject.transform.position = WaypointA.transform.position;

	}

	void Update() {

		if (InSight == true) {


		} 

		if (InSight == false) {

			if (gameObject.transform.position == WaypointA.transform.position) {

				direction = true;

			}

			if (gameObject.transform.position == WaypointB.transform.position) {

				direction = false;

			}

			if (direction == true) {

				transform.LookAt (WaypointB);
				transform.position += Vector3.forward * Time.deltaTime * patrolSpeed;

			}

			if (direction == false) {

				transform.LookAt (WaypointA);
				transform.position += Vector3.forward * Time.deltaTime * patrolSpeed;
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
