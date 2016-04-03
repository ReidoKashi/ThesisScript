using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {

	public Texture imageToDisplay;
	public Texture image2;
	public float timeToDisplayImage;
	public float loadGame;
	public int loadGameApp;

	
	private float timeForNextLevel;
	private float gameLoaded;

	public void Start() {
		timeForNextLevel = Time.time + timeToDisplayImage;
		gameLoaded = Time.time + loadGame;
	}
	
	public void OnGUI() {
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), imageToDisplay);
		if (Time.time >= timeForNextLevel) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), image2);
			if (Time.time >= gameLoaded) {
				Application.LoadLevel (loadGameApp);
			}
		}
	}
}
// script taken and modified from http://answers.unity3d.com/questions/574164/multiple-splash-screens-for-a-game-intro.html