using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	// Use this for initialization
	private Network networkhub;
	void Start () {
		networkhub=GameObject.Find ("network hub").GetComponent<Network> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (networkhub.isLoaded ()) {
			Debug.Log (networkhub.getXY ());
		} else {
			networkhub.NetworkLoad ();
		}

		networkhub.NetworkSend (Input.mousePosition.x, Input.mousePosition.y);
	}
}
