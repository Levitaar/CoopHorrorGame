using UnityEngine;
using System.Collections;
using Application;

public class Network : MonoBehaviour {
	void Start () {}

	private const string URL = "http://california.thixlab.com:9000/xy";
	private Vector2 xy;
	private bool loaded;
	public void NetworkLoad(){
		loaded = false;
		StartCoroutine(Load(new WWW(URL)));
	}
	public void NetworkSend(float x,float y){
		StartCoroutine(Request(new WWW(URL+"?x="+x+"&y="+y)));
	}

	public Vector2 getXY(){
		return xy;
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
			xy = new Vector2 (float.Parse(myXY.x), float.Parse(myXY.y));
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