using UnityEngine;
using System.Collections;

public class EnemyBody : MonoBehaviour {

	// Use this for initialization
	private Network networkhub;

	void Start () {
		networkhub=GameObject.Find ("nethub").GetComponent<Network> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other) {

		if (other.gameObject.name == "PlayerCam") {

			networkhub.NetworkSendDeath (true);

		}

	}

}
