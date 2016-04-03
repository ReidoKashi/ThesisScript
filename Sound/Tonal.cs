using UnityEngine;
using System.Collections;

public class Tonal : MonoBehaviour {
	public Transform spawnPoint;
	public AudioSource Soundmanage;
	public AudioClip morphFX1;
	public AudioClip morphFX2;
	public AudioClip compliment1;
	public AudioClip compliment2;
	public AudioClip compliment3;
	public float updatedTone; 
	private int randClip;
	private float fn = 1f;
	private float fn2 = -1f;
	public GameObject starterTrack;
	public GameObject triangleGate, circleGate, squareGate;
	public GameObject[] gates; 
	//new Vector3(0,0,25);
	//private new Vector3 myPosition = gameObject.transform.position;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame

	void Update (){
		//updateSound ();
	}




	void updateSound()

	{
		//float numAdd = .04f;
		Debug.Log (updatedTone);
		//Debug.Log (myPosition);
		//Soundmanage.clip = sfxTone;

		if (!Soundmanage.isPlaying) {

			Soundmanage.Play ();
			Soundmanage.panStereo = updatedTone;
		} else {
			Soundmanage.panStereo = updatedTone;
			updatedTone = updatedTone + .25f;

			if (updatedTone == fn)
			{ 
				callGate();
				Debug.Log ("made it");
				//Soundmanage.Stop ();
				updatedTone = -1;
			}
		
		}


	}





	void callGate()
	{ randClip = Random.Range (1, 4);
		Debug.Log ("gate is being called");
		if (randClip == 1) {
			GameObject newGate;
			newGate = Instantiate (circleGate, spawnPoint.transform.position, spawnPoint.rotation) as GameObject;
		} else if (randClip == 2) { GameObject newGate;
			newGate = Instantiate (squareGate, spawnPoint.transform.position, spawnPoint.rotation) as GameObject;

		} else if (randClip == 3) {
			GameObject newGate;
			newGate = Instantiate (triangleGate, spawnPoint.transform.position, spawnPoint.rotation) as GameObject;
		}
	}



}
