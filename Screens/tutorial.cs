using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {
	public Texture[] screens = new Texture[14];
	public float timer;

	private bool flipper = false ;//this bool will act as a debounce for the incrementing number
	private int slideCount = 0;
	// Use this for initialization
	void Start () {
		timer = Time.time + timer;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),screens[slideCount]);
	}
	
	// Update is called once per frame
	void OnGUI () {
		Debug.Log ("pulse");
		Debug.Log(slideCount);
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),screens[slideCount]);


		if (slideCount <= 12) {
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.A) || Input.GetButton ("joy_1") || Input.GetButton ("joy_2") || Input.GetButton ("joy_3")) {
				if (flipper == false) {
					slideCount++;
					GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), screens [slideCount]);
					flipper = true;
				}

			}

			if (Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.A) || Input.GetButtonUp ("joy_1") || Input.GetButtonUp ("joy_2") || Input.GetButtonUp ("joy_3")) {
				flipper = false;

	
			}
		} else if(slideCount == 13)
		{Application.LoadLevel(3);
}
}
}