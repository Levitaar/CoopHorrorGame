using UnityEngine;
using System.Collections;
using Application;

public class Network : MonoBehaviour {
	void Start () {
		NetworkSendDeath (false);
	}

	private const string URL = "http://california.thixlab.com:9000/xy";
	private Vector3 xyz;
	private float r;
	public string isDead;
	private bool loaded;

	public void NetworkLoad(){
		loaded = false;
		StartCoroutine(Load(new WWW(URL)));
	}
	public void NetworkSend(float x,float y,float z,float r){
		if (isDead != "1") {
			StartCoroutine (Request (new WWW (URL + "?x=" + x + "&y=" + y + "&z=" + z + "&r=" + r)));
		}
	}
	public void NetworkSendDeath(bool isDead){
		print (isDead);
		if (isDead) {
			StartCoroutine (Request (new WWW (URL + "?x=0&y=0&r=0&d=1")));
		} else {
			StartCoroutine (Request (new WWW (URL + "?x=0&y=0&r=0&d=0")));
		}
	}

	public Vector3 getXYZ(){
		return xyz;
	}
	public float getR(){
		return r;
	}
	public bool isLoaded(){
		return loaded;
	}
	public void reload(){
		loaded = false;
	}
	private IEnumerator Load(WWW www)
	{
		yield return www;
		// check for errors
		if (www.error == null)
		{
			loaded = true;

			xyObject myXY = JsonUtility.FromJson<xyObject>(www.text);
			xyz = new Vector3 (float.Parse(myXY.x), float.Parse(myXY.y),float.Parse(myXY.z));
			isDead = myXY.d;
			if (isDead == "1") {
				UnityEngine.Application.Quit ();
			}
			r=float.Parse(myXY.r);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}

	private IEnumerator Request(WWW www)
	{
		yield return www;
		// check for errors
		if (www.error == null)
		{
			//Debug.Log(www.text);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}

}