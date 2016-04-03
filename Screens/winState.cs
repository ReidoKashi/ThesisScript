using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class winState : MonoBehaviour {

	public AudioSource winSong;
	public AudioMixerSnapshot winSnapshot;
	public Texture winPic;
	public bool winTrue = true;
	
	void Start(){
		winTrue = false;

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


	}
}
