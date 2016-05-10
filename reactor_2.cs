﻿using UnityEngine;
using System.Collections;

public class reactor_2 : MonoBehaviour 
{
		
		
		[Header("LOGIC")]
		public lang _language;
		public Camera cam;
		
		[Header("VARS")]
		[Tooltip("1pink 2green 3yellow")]
		public int levelchange;
		public float time = .25f;
		public float gradate = .01f;
		public float duration = .15f;
		public int incre = 0;
		
		[Header("COLORS")]
		
		public Color[] colors = new Color[6];
		[Header("EFFECTS")]
		public GameObject particleSys;
		
		[Header("SFX")]
		public AudioSource pinkAB;
		public AudioSource greenAB;
		public AudioSource yellowAB;
		public AudioSource pinkBA;
		public AudioSource greenBA;
		public AudioSource yellowBA;
		public AudioSource damage;
		public AudioSource match;
		public bool songCan = true;
		void callSong(int lvl)
		{
			if (songCan) 
			{Debug.Log ("calling song pulse");
				songCan = false;
				switch(lvl)
				{case 1:
						pinkBA.Play ();
					break;
					
				case 2:
					greenBA.Play ();
					break;
					
				case 3:
					yellowBA.Play ();
					break;
					
				}
			}
			
			
		}
		
		
		
		public void OnTriggerStay(Collider col)
		{
			
			
			
			if (levelchange == 1) {
				if (col.gameObject.tag == "Circle") {
					backPink();
					callSong(levelchange);
					//_language.colorJump ();
					//match.Play ();
					//pink.Play();			
				} else if (col.gameObject.tag == "Triangle") {
					//				damage.Play ();
					wrong();
					//				wronglevelchange (1);
				} else if (col.gameObject.tag == "Square") {
					wrong();
					//				wronglevelchange (1);
				} else if (col.gameObject.tag == "RESET") 
				{
					Debug.Log("Regular Pulse");
					reg();
					
				}
			} else if (levelchange == 2) {
				if (col.gameObject.tag == "Triangle") {
					backGreen();
					//				_language.colorJump ();
					//				match.Play ();
					//pink.Play();			
				} else if (col.gameObject.tag == "Circle") {
					wrong();
					//				damage.Play ();
					//				wronglevelchange (1);
				} else if (col.gameObject.tag == "Square") {
					//				damage.Play ();
					//				wronglevelchange (1);
					wrong();
				}
			} else if (levelchange == 3) {
				if (col.gameObject.tag == "Square") {
					//				_language.colorJump ();
					//				match.Play ();
					backYellow();			
				} else if (col.gameObject.tag == "Circle") {
					//				damage.Play ();
					//				wronglevelchange (1);
					wrong();
				}else if
				(col.gameObject.tag == "Triangle") {
					//				damage.Play ();
					//				wronglevelchange (1);
					wrong();
				}
			}
			
			
			
		}
		
		void wronglevelchange(int incre){
			incre += 1;
			if (incre <= 1) {
				StartCoroutine (wrongCo ());
			} else if(incre > 1) {
				StartCoroutine (wrongCo_2 ());
			}
		}
		
		
		
		IEnumerator wrongCo() 
		{
			Color currentColor = cam.backgroundColor;
			
			damage.Play ();
			
			
			float time = .25f;
			float logic = gradate / duration;
			while (time < 1) {
				
				cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[3], time);
				time += logic;
				yield return new WaitForSeconds (gradate);
				
				
			}
			
			
		}
		
		IEnumerator wrongCo_2 () 
		{
			Color currentColor = cam.backgroundColor;
			
			damage.Play ();
			
			
			float time = .25f;
			float logic = gradate / duration;
			while (time < 1) {
				
				cam.backgroundColor = Color.LerpUnclamped (currentColor, colors [4], time);
				time += logic;
				yield return new WaitForSeconds (gradate);
				
				
			}
		}
		
		IEnumerator resetPlease () 
		{
			Color currentColor = cam.backgroundColor;
			
			
			
			
			float time = .25f;
			float logic = gradate / duration;
			while (time < 1) {
				
				cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[5], time);
				time += logic;
				yield return new WaitForSeconds (gradate);
				
				
			}
			
		}
		
		void backPink()
		{//pinkBA.Play ();
			Color currentColor = cam.backgroundColor;
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[0], time);
			
		}
		void backGreen()
		{Color currentColor = cam.backgroundColor;
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[1], time);
			
		}
		void backYellow()
		{
			Color currentColor = cam.backgroundColor;
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[2], time);
			
		}
		
		void wrong()
		{
			Color currentColor = cam.backgroundColor;
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[4], time);
			damage.Play ();
		}
		
		void reg()
		{
			Color currentColor = cam.backgroundColor;
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[5], time);
		}
		
		
		
		////////////////////
	/// 
	/// 
	/// 
	/// reactor 1 logic
	///////////////
	void OnTriggerEnter (Collider col)
	{
		
		if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square" || col.gameObject.tag == "RESET" ) {
			switchCall (levelchange);
		}
	}
	
	public void resetMe ()
	{
		StartCoroutine (resetMeCo ());
	}
	
	public IEnumerator resetMeCo ()
	{ 
		
		
		
		Color currentColor = cam.backgroundColor;
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) {
			
			
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[5], time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
		}
		
		
		return true;
		
		
	}
	
	void switchCall (int levelchange)
	{
		switch (levelchange) 
		{
		case 1:
			pinkAB.Play ();
			resetMe ();
			break;
			
		case 2: 
			greenAB.Play ();
			resetMe ();
			break;
			
		case 3: 
			yellowAB.Play ();
			resetMe ();
			break;
			
		}
	}		
		
	}
	
	
	
	
	
	
	
	
