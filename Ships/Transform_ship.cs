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
			Debug.Log ("W was pressed");
			gameObject.tag = "Triangle";
		}


		// S pressed - and Square ship activated
	if (Input.GetKey(KeyCode.S))
		{
			anim.SetInteger("Ship_State",2);
			//Square_Ship.GetComponent<Animation>().Play ("Square_A");
			Debug.Log ("S was pressed");
			gameObject.tag = "Square";
		}

		// A pressed - and Circle ship activated
		if (Input.GetKey(KeyCode.A))
		{	
			anim.SetInteger("Ship_State",0);
			//Circle_Ship.GetComponent<Animation>().Play ("Circle_A");
			Debug.Log ("A was pressed");
			gameObject.tag = "Circle";
		}
	}
}