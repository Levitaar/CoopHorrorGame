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

		networkhub.NetworkSend (transform.position.x, transform.position.y,transform.position.z,transform.rotation.y);
	}
}
