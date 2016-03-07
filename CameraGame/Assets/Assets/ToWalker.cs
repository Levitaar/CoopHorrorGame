using UnityEngine;
using System.Collections;

public class ToWalker : MonoBehaviour {

	public bool walker = false;

	void Start () {
	
		walker = false;
	}
	

	void Update () {
	
	}

	void Next() {

		walker = true;

		if (walker == true) {

			Application.LoadLevel ("Walker_Scene1");

		}

	}
}
