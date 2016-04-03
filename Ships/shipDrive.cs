using UnityEngine;
using System.Collections;

public class shipDrive : MonoBehaviour {
	public float initPush;
	public float cruise;
	public Rigidbody rb;
	public float timer;
	// Use this for initialization
	void Start () {
		timer = Time.time + timer;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time <= timer) {
			// this timer makes the game easier as the  if you let the cruise go without
			//any infraction the game will be to hard, and to fast

			rb.AddForce (new Vector3 (0, 0, cruise), ForceMode.Force);
		}



}
	void Update()
	{
		if (Input.GetButton("joy_4")){
			
			rb.AddForce (new Vector3 (0, 0, 25f), ForceMode.Force);
			Debug.Log ("speed up debug");
		}
	
	
		if (Input.GetButton("joy_5")){
			
			rb.AddForce (new Vector3 (0, 0, -25f), ForceMode.Force);
			Debug.Log ("speeddown debug");
		}
	
	
	}
		}
