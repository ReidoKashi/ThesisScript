using UnityEngine;
using System.Collections;

public class tut_2 : MonoBehaviour {

	public GameObject textArt;
	
	
	void Update()
	{
		if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.A)||Input.GetButton("joy_1")||Input.GetButton("joy_2")||Input.GetButton("joy_1"))
		{
			textArt.SetActive(false);

			sendMethod();

		}
	}
	
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			textArt.SetActive(true);
			Time.timeScale = 0;
			
			
		}
		
	}

	void sendMethod(){
		Time.timeScale = 1;
	}
}
