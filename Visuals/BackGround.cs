using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {
	// Color Arrays
	//public Color[] Gate_Colors;
	// Three gate colors
	public Color Square_Color;
	public Color Triangle_Color;
	public Color Circle_Color;
	// Variables to change Lurp
	public float duration = 0.02f;
	public float gradate = 2;
	// Calling Camera

	public Camera cam;


	// Use this for initialization
	void Start () {

//		Gate_Colors = new Color[2];

//
//		Gate_Colors[0] = Square_Color;
//		Gate_Colors[1] = Triangle_Color;
//		Gate_Colors[2] = Circle_Color;
	
	}
	
	// Update is called once per frame

		//collision logic with gates
		
	public void callBackC(){

		StartCoroutine (Lurp_C ());

	}
	public void callBackS(){
		
		StartCoroutine (Lurp_S ());
		
	}
	public void callBackT(){
		
		StartCoroutine (Lurp_T ());
		
	}
		public IEnumerator Lurp_T()
		{
		 Color currentColor = cam.backgroundColor;

			float time = .5f;
			float logic = gradate / duration;
			while (time < 1) 
			{
				
				//time += Time.deltaTime* 5;
				//time += Time.time;
				
			cam.backgroundColor = Color.LerpUnclamped(currentColor,Triangle_Color,time);
				time += logic;
				yield return new WaitForSeconds(gradate);
				Debug.Log ("backLurpS");
				
			}
			return true;
		}

		public IEnumerator Lurp_C()
		{
		 Color currentColor = cam.backgroundColor;
			float time = .5f;
			float logic = gradate / duration;
			while (time < 1) 
			{
				
				//time += Time.deltaTime* 5;
				//time += Time.time;
				
			cam.backgroundColor = Color.LerpUnclamped(currentColor,Circle_Color,time);
				time += logic;
				yield return new WaitForSeconds(gradate);
				Debug.Log ("backLurpS");
				
			}
			
		}

		public IEnumerator Lurp_S()
		{
		 Color currentColor = cam.backgroundColor;
			float time = .5f;
			float logic = gradate / duration;
			while (time < 1) 
			{
				
				//time += Time.deltaTime* 5;
				//time += Time.time;
				
			cam.backgroundColor = Color.LerpUnclamped(currentColor,Square_Color,time);
				time += logic;
				yield return new WaitForSeconds(gradate);
				Debug.Log ("backLurpS");
				
			}
			return true;
		}

	
}
