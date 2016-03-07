using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PrefabSelector : NetworkManager {

	public override void OnServerConnect(NetworkConnection conn) {

		print ("player connected");

		if (Network.isClient) {

			print ("Player is Client");

		} else if (Network.isServer) {

			print ("Player is Server");

		}

	}

}
