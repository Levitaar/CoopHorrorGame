using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMov : NetworkBehaviour {

	void Update()
	{

		if (!isLocalPlayer) {
			return;

		}

		var x = Input.GetAxis("Horizontal")*0.3f;
		var z = Input.GetAxis("Vertical")*0.3f;
		
		transform.Translate(x, 0, z);


	}

}

