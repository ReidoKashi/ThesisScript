using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {
	[Header("PICTURES")]
	public Texture[] screens = new Texture[15];
	public float timer;
	private bool flipper = false ;//this bool will act as a debounce for the incrementing number
	private int slideCount = 0;

	[Header("SOUND")]
	public AudioSource[] newSounds = new AudioSource[4];
	public int currentSound = 0;
	public bool audioPlay = true;


	// Use this for initialization
	void Start () {

		timer = Time.time + timer;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),screens[slideCount]);
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
		Debug.Log (slideCount);
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), screens [slideCount]);
		if (slideCount == 14) {
			if (Input.GetKeyDown (KeyCode.W)) {
				Application.LoadLevel (3);
			}
		}
		if (slideCount <= 14) {

			
			if (slideCount >= 12) {
				if (Input.GetKeyDown (KeyCode.W))
				{playSoundEf();
				}
//				if (audioPlay) {
//					audioPlay = false;
//					playSoundEf ();
//
//				}
			}
			if (Input.GetKeyDown (KeyCode.A)) {
				if (flipper == false) {
					slideCount++;
					if (slideCount >= 12)
					{currentSound++;
					}
					GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), screens [slideCount]);
					flipper = true;
				}

			}

			if (Input.GetKeyUp (KeyCode.A)) {
				flipper = false;

	
			}
		} else if(slideCount == 14){
			Application.LoadLevel (3);
		}
	}


	void playSoundEf()
	{
		newSounds [currentSound].Play ();
		StartCoroutine (turnOffSound());
	}
	IEnumerator turnOffSound()
	{yield return new WaitForSeconds (5);
		audioPlay = true;
		//newSounds [currentSound].Stop ();
		AudioStopper ();
	}
	void AudioStopper(){
		 AudioSource[] allAudio;
		allAudio = FindObjectsOfType(typeof (AudioSource)) as AudioSource[];
		foreach(AudioSource audioFX in allAudio) {
			audioFX.Stop();
				}
		}
}

// all audio stop code take from source:http://answers.unity3d.com/questions/194110/how-to-stop-all-audio.html with user| dpanov76mail.ru |