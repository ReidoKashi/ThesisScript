using UnityEngine;
using System.Collections;

public class rescueTalk : MonoBehaviour {
	public ParticleSystem speedUp;
	public GameObject rescueShip1;
	public Vector3 rescuePortal;
	public float numCruise;
	Animator anim; 
	// Use this for initialization
	void Start () {
		speedUp.Stop ();
	}
	
	// Update is called once per frame
	void Update () {

		if (rescueShip1.GetComponent<Animator>().GetBool("stateGo") == true) {
			rescueShip1.transform.Translate(rescuePortal * numCruise * Time.fixedDeltaTime);


		}

	}

	public void callRescue_1 ()
	{Debug.Log ("call Rescue 1");

		rescueShip1.GetComponent<Animator> ().SetBool ("stateGo", true);

	}

	public void callRescue_add ()
	{Debug.Log ("rescue ship should be boosting");
		rescueShip1.transform.TransformVector(Vector3.back * numCruise);
		
	}


}
