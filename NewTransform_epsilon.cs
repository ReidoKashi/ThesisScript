using UnityEngine;
using System.Collections;

public class NewTransform_epsilon : MonoBehaviour
{
	[Header("FEATURES")]
	public bool controlLock; //controlLock locks the control until input can be given
	public GameObject Player_Ship;
	public GameObject stateTri;
	public GameObject statePink;
	public GameObject stateYellow;
	public GameObject stateReset;

	//This script will tranform the player ship into another ship, if  W,S, or A is pressed
	void Start ()
	{
		controlLock = true;
		stateReset.SetActive (true); 
		statePink.SetActive (false);
		stateTri.SetActive (false);
		stateYellow.SetActive (false);
	}
	//Circle ship is started by default
	
	void FixedUpdate ()
	{
		if (!controlLock) 
		{
			// W pressed - and triangle ship activated
			if (Input.GetKeyDown (KeyCode.W) || Input.GetKey (KeyCode.W)) {
				stateReset.SetActive (false); 
				statePink.SetActive (false);
				stateTri.SetActive (true);
				stateYellow.SetActive (false);
				//anim.SetInteger("FORM",2);
				//Triangle_Ship.GetComponent<Animation>().Play ("Triangle_A");
				gameObject.tag = "Triangle";
			}
		
		
			// S pressed - and Square ship activated
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKey (KeyCode.S)) {
				stateReset.SetActive (false);
				statePink.SetActive (false);
				stateTri.SetActive (false);
				stateYellow.SetActive (true);
				//anim.SetInteger("FORM",3);
				Debug.Log ("S was pressed");
				gameObject.tag = "Square";
			}
		
			// A pressed - and Circle ship activated
			if (Input.GetKeyDown (KeyCode.A) || Input.GetKey (KeyCode.A)) {	
				stateReset.SetActive (false);
				statePink.SetActive (true);
				stateTri.SetActive (false);
				stateYellow.SetActive (false);
				//anim.SetInteger ("FORM", 1);
				gameObject.tag = "Circle";
			}
		} else 
		{



		}
		
		//		if (Input.GetButton("joy_1"))
		//		{
		//
		//			anim.SetInteger("Ship_State",1);
		//			gameObject.tag = "Triangle";
		//		}
		//		
		//		if (Input.GetButton("joy_2"))
		//		{
		//
		//			anim.SetInteger("Ship_State",2);
		//			gameObject.tag = "Square";
		//		}
		//		
		//		if (Input.GetButton("joy_3"))
		//		{	
		//
		//			anim.SetInteger("Ship_State",0);
		//			gameObject.tag = "Circle";
		//		}
		
		
		
		
	}

	public void resetPlayer ()
	{ controlLock = true;
		stateReset.SetActive (true);
		statePink.SetActive (false);
		stateTri.SetActive (false);
		stateYellow.SetActive (false);
		gameObject.tag = "RESET";
	}
	
	public void controlRelease()
	{controlLock = false;
	}
	// alternaate controller joystick
}
