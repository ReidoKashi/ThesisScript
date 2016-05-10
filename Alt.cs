using UnityEngine;
using System.Collections;

public class Alt : MonoBehaviour {
	[Header("LOGIC")]
	public lang _language;
	public Increment _language_2;

	[Header("VARS")]

	public int levelchange;
	public float time;
	public float gradate;
	public float duration;

	[Header("COLORS")]

	public Color[] colors = new Color[3];
	


	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square") 
		{Debug.Log ("hello pulse");
			methodCall (levelchange);
		}
	}

	public void methodCall(int levelchange)
	{
	
		switch (levelchange) 
		{
		case 1:
			_language.colorJump3();
			_language_2.compliAud_3.Play();
			break;

		case 2:
			_language.colorJump();
			_language_2.compliAud_1.Play();
			break;
			
		case 3:
			_language.colorJump2();
			_language_2.compliAud_2.Play();
			break;

		case 4:
			_language_2.compliAud_3.Play();
			_language.colorJump2();
			break;
			
		case 5:
			_language_2.compliAud_1.Play();
			_language.colorJump3();
			break;
			
		case 6:
			_language_2.compliAud_2.Play();
			_language.colorJump();
			break;

		case 7:
			_language_2.compliAud_3.Play();
			_language.colorJump();
			break;

		case 8:
			_language_2.compliAud_1.Play();
			_language.colorJump2();
			break;

		case 9:
			_language_2.compliAud_2.Play();
			_language.colorJump3();
			break;
	
		}
	
	}










}














