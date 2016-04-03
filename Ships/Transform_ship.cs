using UnityEngine;
using System.Collections;

public class Transform_ship : MonoBehaviour {
	public GameObject Player_Ship;

	Animator anim;
	//This script will tranform the player ship into another ship, if  W,S, or A is pressed
	void Start () {
		anim = GetComponent<Animator> ();

	}
	//Circle ship is started by default

		void FixedUpdate () 

	{

		// W pressed - and triangle ship activated
	if (Input.GetKey(KeyCode.W))
		{
			anim.SetInteger("Ship_State",1);
			//Triangle_Ship.GetComponent<Animation>().Play ("Triangle_A");
			gameObject.tag = "Triangle";
		}


		// S pressed - and Square ship activated
		if (Input.GetKey(KeyCode.S))
		{
			anim.SetInteger("Ship_State",2);
			Debug.Log ("S was pressed");
			gameObject.tag = "Square";
		}

		// A pressed - and Circle ship activated
		if (Input.GetKey(KeyCode.A))
		{	
		//	_morphSystem.animPin();
			anim.SetInteger("Ship_State",0);
			gameObject.tag = "Circle";
		}
	
		if (Input.GetButton("joy_1"))
		{

			anim.SetInteger("Ship_State",1);
			gameObject.tag = "Triangle";
		}
		
		if (Input.GetButton("joy_2"))
		{

			anim.SetInteger("Ship_State",2);
			gameObject.tag = "Square";
		}
		
		if (Input.GetButton("joy_3"))
		{	

			anim.SetInteger("Ship_State",0);
			gameObject.tag = "Circle";
		}
	
	
	
	
	}


	// alternaate controller joystick
}