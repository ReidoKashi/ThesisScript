using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class still : MonoBehaviour {
	public Canvas faderSystem;
	public ParticleSystem speed;
	public ParticleSystem origPart;
	public AudioMixer mixer;
	public AudioMixerSnapshot snapshot_1;
	public AudioMixerSnapshot snapshot_main;
	public GameObject rescueEnd;
	public GameObject rescueBody;
	public Vector3 adD = new Vector3(0,0,5);
	public float bigNum = 200f;

	// Use this for initialization
	void Start () {
		snapshot_main.TransitionTo(0f);
		speed.Stop();
	}
	
	// Update is called once per frame
	void Update () 
	{

		//gameObject.transform.Translate(
		//while trigger dosent hit player and collects ship and set off the trigger --
		if (rescueEnd.GetComponent<Animator>().GetBool("rescueFinal") == false) {     

			//rescueBody.transform.Translate (adD * bigNum * Time.deltaTime); 
			StartCoroutine (finalRescue());
		} 
	}

	void OnTriggerEnter(Collider Col)
	{
			// on final animation when backing up, if collider hits player start coroutine

			if (Col.gameObject.tag == "Player") 
		{ Debug.Log ("rescue call");
			// start coroutine for combo animation - and destroying gameobject
				
			}
			

	
	}

		 IEnumerator finalRescue(){
			yield return new WaitForSeconds(14f);
		rescueEnd.GetComponent<Animator>().SetBool("rescueFinal",true);
		yield return new WaitForSeconds(4f);
		faderSystem.GetComponent<Animator> ().SetBool ("fill_white", true);
		//Destroy (rescueEnd);
		}
	void transitionMusic()
	{ Debug.Log ("music is called");
		snapshot_1.TransitionTo (.6f);

	}

	void particleTransition(){
		speed.Play ();
		origPart.Stop ();
	}


}
