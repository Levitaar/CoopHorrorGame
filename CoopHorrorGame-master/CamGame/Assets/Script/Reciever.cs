using UnityEngine;
using System.Collections;

public class Reciever : MonoBehaviour {

	// Use this for initialization
	private Network networkhub;
	private Vector3 xy;
	private float speed=0.1f;
	void Start () {
		networkhub=GameObject.Find ("nethub").GetComponent<Network> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (networkhub.isLoaded ()) {
			xy = new Vector3 (networkhub.getXYZ ().x, networkhub.getXYZ ().y, networkhub.getXYZ ().z);
			networkhub.reload ();

		} else {
			networkhub.NetworkLoad ();
		}
		//print (transform.position.x + "," + transform.position.y + "," + transform.position.z);
		//print (xy.x + "," + xy.y + "," + xy.z);
		if (xy!=null) {
			float dx = xy.x - transform.position.x;
			if (Mathf.Abs (dx) > 0.1f) {
				transform.position=new Vector3(transform.position.x+dx * 0.2f, transform.position.y, transform.position.z);
			}
			float dy = xy.y - transform.position.y;
			if (Mathf.Abs (dy) > 0.1f) {
				transform.position=new Vector3(transform.position.x, transform.position.y+dy * 0.2f, transform.position.z);
			}
			float dz = xy.z - transform.position.z;
			if (Mathf.Abs (dz) > 0.1f) {
				transform.position=new Vector3(transform.position.x, transform.position.y, transform.position.z+dz * 0.2f);
			}
		}
		//transform.position = xy;
		transform.localEulerAngles = new Vector3(0,networkhub.getR ()*180f,0);

		//networkhub.NetworkSend (Input.mousePosition.x, Input.mousePosition.y);
	}
}
