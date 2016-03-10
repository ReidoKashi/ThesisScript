using UnityEngine;
using System.Collections;

public class Tonal_2 : MonoBehaviour {

	public AudioSource Soundmanage;
	public AudioClip sfxTone;
	public float updatedTone; 
	private float fn = 1f;
	public GameObject triangleGate,circleGate,squareGate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void updateSound()
		
	{
		//float numAdd = .04f;
		Debug.Log (updatedTone);
		Soundmanage.clip = sfxTone;
		
		if (!Soundmanage.isPlaying) {
			Soundmanage.Play ();
			Soundmanage.panStereo = updatedTone;
		} else {
			Soundmanage.panStereo = updatedTone;
			updatedTone = updatedTone + .25f;
			
			if (updatedTone == fn)
			{ GameObject newGate;
				
			}
			
		}

	}
}