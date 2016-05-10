using UnityEngine;
using System.Collections;

public class musLang : MonoBehaviour
{
	[Header("LOGIC")]
	public float
		gradate = .01f;
	public float duration = .15f;
	public Camera cam;
	[Tooltip("1 pink 2 green 3 yellow")]
	public int
		choice;
	[Header("COLORS")]
	public Color
		resetBackColor;
	[Header("SOUND")]
	public AudioSource
		pinkAB;
	public AudioSource pinkBA;
	public AudioSource greenAB;
	public AudioSource greenBA;
	public AudioSource yellowAB;
	public AudioSource yellowBA;
	public AudioSource damage;
	public AudioSource match;
	public AudioSource[] allAudio;

	public void winGate ()
	{
		match.Play ();
	}

	public void playGateFeedBack (int gateKind)
	{
		switch (gateKind) {
		case 1:
			pinkBA.Play ();
			break;
		
		case 2:
			greenBA.Play ();
			break;
		
		case 3:
			yellowBA.Play ();
			break;
		
		}
	}
	
	void OnTriggerEnter (Collider col)
	{
		Debug.Log ("choice is now this" + choice);
		if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square" || col.gameObject.tag == "RESET" || col.gameObject.tag == "Player") {
			switchCall (choice);
		}
	}
	
	public void resetMe ()
	{
		StartCoroutine (resetMeCo ());
	}
	
	public IEnumerator resetMeCo ()
	{ 
		
		
		
		Color currentColor = cam.backgroundColor;
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) {
			
			
			cam.backgroundColor = Color.LerpUnclamped (currentColor, resetBackColor, time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
		}
		
		
		return true;
		
		
	}
	
	void switchCall (int choice)
	{
		switch (choice) {
		case 1:
			pinkAB.Play ();
			resetMe ();
			break;
			
		case 2: 
			Debug.Log ("greend pulse");
			greenAB.Play ();
			resetMe ();
			break;
			
		case 3: 
			Debug.Log ("the yellow choice is playing");
			yellowAB.Play ();
			resetMe ();
			break;
			
		}
	}

	public void endMusicSuccess ()
	{
		pinkAB.Stop ();
		pinkBA.Stop ();
		yellowAB.Stop ();
		yellowBA.Stop ();
		greenAB.Stop ();
		greenBA.Stop ();
		match.Play ();

	}

	public void endMusicFailure ()
	{
		pinkAB.Stop ();
		pinkBA.Stop ();
		yellowAB.Stop ();
		yellowBA.Stop ();
		greenAB.Stop ();
		greenBA.Stop ();
		damage.Play ();
		
	}
}
