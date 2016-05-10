//-----------------------------------------
//   Ralph Moreau
//   http://reidodesign.co
//   @ReidoKashi
//
//   last edit on 4/25/2016
//-----------------------------------------


using UnityEngine;
using System.Collections;

public class tut_1 : MonoBehaviour 

{
	[Header("LOGIC")]
	[Space(50,order =1)]
	public GameObject textGame;
	[Space(5,order =2)]
	[Tooltip("1=all,2=Triangle,3=Square,4=Circle")]
	public int inputLogic;






	void Update()
		{
		switch (inputLogic) {
		case 1:
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.A) || Input.GetButton ("joy_1") || Input.GetButton ("joy_2") || Input.GetButton ("joy_3")) {
				textGame.SetActive (false);
				Time.timeScale = 1;
			}
			break;
		case 2:
		
			if (Input.GetKey (KeyCode.W) || Input.GetButton ("joy_3")) {
				textGame.SetActive (false);
				Time.timeScale = 1;	
			}
			break;
		case 3:
		
			if (Input.GetKey (KeyCode.S) || Input.GetButton ("joy_2")) {
				textGame.SetActive (false);
				Time.timeScale = 1;	
			}
			break;
		case 4: 
		
			if (Input.GetKey (KeyCode.A) || Input.GetButton ("joy_1")) {
				textGame.SetActive (false);	
				Time.timeScale = 1;
			}
			break;
		}
	}
	
void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square" ) 
		{
			textGame.SetActive(true);
			Time.timeScale = 0;


		}

	}

}
