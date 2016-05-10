using UnityEngine;
using System.Collections;

public class Start_It : MonoBehaviour {
	public Texture demoScreen;
	void Start () {

	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), demoScreen);
		if (Input.GetKeyDown (KeyCode.W) || Input.GetButton ("joy_2")) {

			Application.LoadLevel (3);
		} else if (Input.GetKeyDown (KeyCode.A) || Input.GetButton ("joy_1")) 
		{
			Application.LoadLevel (2);
		} else if (Input.GetKeyDown (KeyCode.S) || Input.GetButton ("joy_3")) {
			Application.LoadLevel (3);
		}
		//to do
		Debug.Log ("working");
	}
}
