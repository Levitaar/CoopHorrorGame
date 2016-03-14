using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkSpawn : NetworkManager {
	

	void Start () {
	
	}

	void Update () {
	
	}

	public override void OnServerConnect (NetworkConnection conn) {

		base.OnServerConnect (conn);



	}
}
