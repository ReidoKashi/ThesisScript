//-----------------------------------------
//   Ralph Moreau
//   http://reidodesign.co
//   @ReidoKashi
//
//   last edit on 4/24/2016
//---------------------------------------

using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class winState : MonoBehaviour {
	[Header("Logic")]
	public shipDrive _speedLevel;


	[Header("Sound")]
	public AudioSource winSong;
	public AudioMixerSnapshot winSnapshot;

	[Header("Pictures")]

	public Texture winPic;
	public bool winTrue = true;
	int numOfGatesPassed;
	
	void Start(){
		winTrue = false;

	}
	public void incrementWin()
	{
		Debug.Log (numOfGatesPassed + " this is the number of gates passed");
		numOfGatesPassed++;
		switch (numOfGatesPassed) {
		case 15:
			playWin ();
			break;
//			_speedLevel.switchCruise(2);
//			break;
//		case 20:
//			_speedLevel.switchCruise(3);
//			break;
		case 38:
			playWin ();
			break;
		}
	}

	public void OnGUI(){
		if (winTrue) {
			GUI.DrawTexture (new Rect (Screen.width/2-380,Screen.height/2-195, 727, 409), winPic); 

		}
	}
	
	
	public void playWin()
	{
	winTrue = true;

		Debug.Log ("pulse of winstate");

		StartCoroutine (winningPause ());


	}
	public IEnumerator winningPause(){
		winSong.Play ();
		winSnapshot.TransitionTo (2f);
		Time.timeScale = .5f;
		yield return new WaitForSeconds(1.5f);
		Time.timeScale = 0;

		yield return new WaitForSeconds(8f);
		Application.LoadLevel (1);
	}
}
