using UnityEngine;
using System.Collections;

public class lerpyMover : MonoBehaviour {

	private Transform startPoint,endPoint;

	public float percentage = 1;
	public float speed = .5f;
	private int direction;

	// Use this for initialization
	void Start () {
	
		startPoint = GameObject.Find ("Start Point").transform;
		endPoint = GameObject.Find ("End Point").transform;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = 
			Vector3.Lerp (startPoint.position, endPoint.position, percentage);
		percentage += Time.deltaTime/speed * direction;
		transform.rotation = 
			Quaternion.Lerp 
				(Quaternion.identity, Quaternion.Euler ( new Vector3(180, 0, 0)), percentage);

		gameObject.GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.yellow, percentage);

		speed = Mathf.Max (speed, 0.000001f);

		if (percentage < 0 || percentage > 1) {
			direction = -direction;
			percentage = Mathf.Clamp(percentage, 0, 1);
		}
	}

}
