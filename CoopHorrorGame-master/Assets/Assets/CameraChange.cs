using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

	public Camera Camera1;
	public Camera Camera2;
	public Camera Camera3;
	public Camera Camera4;
	public Camera Camera5;
	public Camera Camera6;
	public Camera Camera7;
	public Camera Camera8;

	public bool C1;
	public bool C2;
	public bool C3;
	public bool C4;
	public bool C5;
	public bool C6;
	public bool C7;
	public bool C8;

	void Start () {
	
		C1 = true;
	}
	

	void Update () {
	
		if (Input.GetKey (KeyCode.Alpha1)) {

			C1 = true;
			C2 = false;
			C3 = false;
			C4 = false;
			C5 = false;
			C6 = false;
			C7 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha2)) {

			C2 = true;
			C1 = false;
			C3 = false;
			C4 = false;
			C5 = false;
			C6 = false;
			C7 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha3)) {

			C3 = true;
			C1 = false;
			C2 = false;
			C4 = false;
			C5 = false;
			C6 = false;
			C7 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha4)) {

			C4 = true;
			C1 = false;
			C2 = false;
			C3 = false;
			C5 = false;
			C6 = false;
			C7 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha5)) {

			C5 = true;
			C1 = false;
			C2 = false;
			C3 = false;
			C4 = false;
			C6 = false;
			C7 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha6)) {

			C6 = true;
			C1 = false;
			C2 = false;
			C3 = false;
			C4 = false;
			C5 = false;
			C7 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha7)) {

			C7 = true;
			C1 = false;
			C2 = false;
			C3 = false;
			C4 = false;
			C5 = false;
			C6 = false;
			C8 = false;

		}

		if (Input.GetKey (KeyCode.Alpha8)) {

			C8 = true;
			C1 = false;
			C2 = false;
			C3 = false;
			C4 = false;
			C5 = false;
			C6 = false;
			C7 = false;

		}

		if (C1 == true) {

			Camera1.enabled = true;

		} else {

			Camera1.enabled = false;

		}

		if (C2 == true) {

			Camera2.enabled = true;

		} else {

			Camera2.enabled = false;

		}

		if (C3 == true) {

			Camera3.enabled = true;

		} else {

			Camera3.enabled = false;

		}

		if (C4 == true) {

			Camera4.enabled = true;

		} else {

			Camera4.enabled = false;

		}

		if (C5 == true) {

			Camera5.enabled = true;

		} else {

			Camera5.enabled = false;

		}

		if (C6 == true) {

			Camera6.enabled = true;

		} else {

			Camera6.enabled = false;

		}

		if (C7 == true) {

			Camera7.enabled = true;

		} else {

			Camera7.enabled = false;

		}

		if (C8 == true) {

			Camera8.enabled = true;

		} else {

			Camera8.enabled = false;

		}
	}
}
