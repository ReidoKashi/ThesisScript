//-----------------------------------------
//   Ralph Moreau
//   http://reidodesign.co
//   @ReidoKashi
//
//   last edit on 4/24/2016
//---------------------------------------

using UnityEngine;
using System.Collections;

public class shipDrive_Delta : MonoBehaviour 
{
	//[Header("Logic"]

	[Header("PROTOTYPE 1")]
	        public bool prototype_1;
	        public float initPush;
	        public float cruise;

	[Header("PROTOTYPE 2")]
	        public bool prototype_2;
	        public bool cruise_1;
	        public bool cruise_2;
	        public bool cruise_3;

	[Header("PROTOTYPE 3")]
	public bool prototype_3;

	[Header("COMPONENT OPTIONS")]
	public Rigidbody rb;
	public float timer;
	public bool boost = false;
	// Use this for initialization
	[Header("GAME CONTROL")]
	bool gamePaused;
	[Header("GAME FEEL")]

		public GameObject initSpeed;
		public GameObject secondSpeed;
		public GameObject thirdSpeed;
		public GameObject trailSystem;


	void Start () {
		timer = Time.time + timer;
		gamePaused = false;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{	//Debug.Log (rb.velocity.z + " this is the velocity");
		//Debug.Log (rb.velocity.z + " is the velocity"); 
		//prototype 1 logic
		if(prototype_1)
	{
		if (Time.time <= timer) 
			{
			// this timer makes the game easier as the  if you let the cruise go without
			//any infraction the game will be to hard, and to fast

			rb.AddForce (new Vector3 (0, 0, cruise), ForceMode.Force);
			}
	}

		if(prototype_2)
	{
		if (cruise_1)
		{ while(!boost)

				{boost = true;
					rb.AddForce (new Vector3 (0, 0,5f), ForceMode.Force);

				}
				rb.AddForce (new Vector3 (0, 0,10f), ForceMode.Force);
				if(rb.velocity.z >= 100)
				{
					Debug.Log ("shooting over the limit");
					rb.AddForce(new Vector3(0,0,-60),ForceMode.Force);
				}
		//  rb.AddForce (new Vector3 (0, 0, -5), ForceMode.Force);
		}else if (cruise_2) 
			 { while(!boost)

					{boost = true;
						rb.AddForce (new Vector3 (0, 0,5f), ForceMode.Force);
						
					}
					rb.AddForce (new Vector3 (0, 0,10f), ForceMode.Force);
					if(rb.velocity.z >= 150)
					{
						Debug.Log ("shooting over the limit");
						rb.AddForce(new Vector3(0,0,-20f),ForceMode.Force);
					}
		}else if(cruise_3)
				while(!boost)

			{boost = true;
				rb.AddForce (new Vector3 (0, 0,1f), ForceMode.Force);
				
			}
			rb.AddForce (new Vector3 (0, 0,5f), ForceMode.Force);
			if(rb.velocity.z >= 60)
			{
				Debug.Log ("shooting over the limit");
				rb.AddForce(new Vector3(0,0,-50f),ForceMode.Force);
			}
	
    }
}
	void Update()
	{
		if(!gamePaused)
		{
			if (Input.GetKey(KeyCode.S)&&Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A))
			{ Time.timeScale = 0;
				gamePaused = true;
			}	
		} else if (gamePaused)
		{ if (Input.anyKey)
			{ Time.timeScale = 1;
			}
			gamePaused = false;
		}
		

		if (Input.GetButton("joy_4")){
			
			rb.AddForce (new Vector3 (0, 0, 25f), ForceMode.Force);
			Debug.Log ("speed up debug");
		}
	
	
		if (Input.GetButton("joy_5")){
			
			rb.AddForce (new Vector3 (0, 0, -25f), ForceMode.Force);
			Debug.Log ("speeddown debug");
		}
	
	
	}


	public void switchCruise(int cruiseSwitch)
	{	switch(cruiseSwitch)
		{
	case 1:
		cruise_1 = true;
		cruise_2 = false;
		cruise_3 = false;
		break;

	case 2:
		cruise_1 = false;
		cruise_2 = true;
		cruise_3 = false;
		
		initSpeed.SetActive(false);
		secondSpeed.SetActive(true);

				break;

	case 3:
			thirdSpeed.SetActive(true);
			trailSystem.GetComponent<Animator>().SetBool("trail",true);
		cruise_1 = false;
		cruise_2 = false;
		cruise_3 = true;
		break;
	
    	}
	}


}