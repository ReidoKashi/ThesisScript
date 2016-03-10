using UnityEngine;
using System.Collections;

public class Start_It : MonoBehaviour {
	//public CrashAmount _crashReset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//_crashReset.resetGo();
		if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.A)){
			Debug.Log("GameStart");
			Application.LoadLevel(1);
		}

	}
}
