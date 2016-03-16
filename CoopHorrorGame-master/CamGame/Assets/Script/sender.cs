using UnityEngine;
using System.Collections;

public class sender : MonoBehaviour {

	// Use this for initialization
	private Network networkhub;
	private Vector3 xy;
	void Start () {
		networkhub=GameObject.Find ("nethub").GetComponent<Network> ();
	}

	// Update is called once per frame
	void Update () {
		if (networkhub.isLoaded ()) {
			networkhub.reload ();
		} else {
			networkhub.NetworkLoad ();
		}
		if (networkhub.isDead=="1") {
			print ("Game Over");
			UnityEngine.Application.Quit ();
		}
		networkhub.NetworkSend (transform.position.x, transform.position.y,transform.position.z,transform.rotation.y);
	}
}
