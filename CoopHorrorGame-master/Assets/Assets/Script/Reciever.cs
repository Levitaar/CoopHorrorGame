using UnityEngine;
using System.Collections;

public class Reciever : MonoBehaviour {

	// Use this for initialization
	private Network networkhub;
	private Vector3 xy;
	void Start () {
		networkhub=GameObject.Find ("nethub").GetComponent<Network> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (networkhub.isLoaded ()) {
			xy = new Vector3 (networkhub.getXY ().x, 2, networkhub.getXY ().y);
			transform.position = xy;
			networkhub.reload ();
		} else {
			networkhub.NetworkLoad ();

		}

		//networkhub.NetworkSend (Input.mousePosition.x, Input.mousePosition.y);
	}
}
