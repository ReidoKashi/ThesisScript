//-----------------------------------------
//   Ralph Moreau
//   http://reidodesign.co
//   @ReidoKashi
//
//   last edit on 4/3/2016
//-----------------------------------------


using UnityEngine;
using System.Collections;

public class lang : MonoBehaviour 
{
	//[Header("Debug_Code")]

	[Header("Logic")]
	public BackGround _phaseChange;
	public winState _winState;
	public loseState _loseState;
	public gateLogic _gateLogic;
	public playerLogic _playerLogic;
	public Camera cam;
	public langTalk _langTalk; // This script increments the amout of gates for the winning state. 
	public collisionCrashC _increment1;
	public collisionCrashS _increment2;
	public collisionCrashT _increment3;


	[Header("Audio")]

	public AudioSource[] gateComp = new AudioSource[3];
	public AudioSource[] gateSfx = new AudioSource[2];

	//[Header("Effects")]

	//[Header("Player")]

	[Header("Gates")]
	public Color[] mainColors = new Color[3];
	public GameObject[] gates = new GameObject[3];
	public GameObject[] phaseGates = new GameObject[3];
	public Color two_col;
	public Color three_col;
	public Color one_col;
//	public int[][][] gateTri = new int[9][][];
//	public int[][][] gateSqu = new int[9];
//	public int[][][] gateCir = = new int[9];
	public float gradate;
	public float duration;
	public float time;
	//language numbers
	//public int rndNum = Random.Range(0,2);
	const int CO = 3;
	const int SO = 3;
	const int SH = 3;
	public GameObject[] pairCheck = new GameObject[3];

	/// Sounds	/// 

	public void sonicIncrement(int passLogic)
	{if (!gateComp [passLogic].isPlaying)
		{ gateComp[passLogic].Play();
			//colorJump(passLogic);
			if(passLogic == 1)
			{StartCoroutine (colorJumpC(passLogic));
			} else if (passLogic == 2)
			{StartCoroutine (colorJumpC2(passLogic));
			} else if (passLogic == 0)
			{ StartCoroutine (colorJumpC3(passLogic));
			}
		}

	}

//	public void colorJump(int passLogic)
//	{ bool pass = false;
//		StartCoroutine (colorJumpC(passLogic,pass));
//	}

	public void colorJump()
	{
		StartCoroutine (colorJumpC(1));
	}

	public void colorJump2()
	{
		StartCoroutine (colorJumpC2(2));
	}


	public void colorJump3()
	{
		StartCoroutine (colorJumpC3(3));
	}



	public IEnumerator colorJumpC(int passLogic)
	{ //_playerLogic.rayInverse ();
		if(passLogic == 0)
		   {Debug.Log("new Square Backdrop");
		} else if (passLogic == 1)
		{Debug.Log("new Triangle Backdrop");
		} else {Debug.Log("new Circle Backdrop");
		}
		           

		           
			Color currentColor = cam.backgroundColor;
	
		    float time = .25f;
			float logic = gradate / duration;
			while (time < 1) 
			{
			
				//time += Time.deltaTime* 5;
				//time += Time.time;
				Debug.Log ("time to code");
				cam.backgroundColor = Color.LerpUnclamped (currentColor, one_col, time);
				time += logic;
				yield return new WaitForSeconds (gradate);

			}
		
	  
			return true;


	}
	
	public IEnumerator colorJumpC2(int passLogic)
	{ //_playerLogic.rayInverse ();
		if (passLogic == 0) {
			Debug.Log ("new Square Backdrop");
		} else if (passLogic == 1) {
			Debug.Log ("new Triangle Backdrop");
		} else {
			Debug.Log ("new Circle Backdrop");
		}
		
		
		
		Color currentColor = cam.backgroundColor;
		
		


			float time = .25f;
		float logic = gradate / duration;
			while (time < 1) {
				
			cam.backgroundColor = Color.LerpUnclamped (currentColor, two_col, time);
			time += logic;
				yield return new WaitForSeconds (gradate);

			
			}
		
		
			return true;

	}
	
	
	
	public IEnumerator colorJumpC3(int passLogic)
	{ //_playerLogic.rayInverse ();
		if (passLogic == 0) {
			Debug.Log ("new Square Backdrop");
		} else if (passLogic == 1) {
			Debug.Log ("new Triangle Backdrop");
		} else {
			Debug.Log ("new Circle Backdrop");
		}
		
		
		
		Color currentColor = cam.backgroundColor;
		
		
		
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) {
			
			cam.backgroundColor = Color.LerpUnclamped (currentColor, three_col, time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			

		}
		
		
		return true;

	}



	public void resetMe(){
		StartCoroutine (resetMeCo ());
	}

	public IEnumerator resetMeCo()
	{ 
		
		
		
		Color currentColor = cam.backgroundColor;
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) 
		{
			
			//time += Time.deltaTime* 5;
			//time += Time.time;
			Debug.Log ("time to code");
			cam.backgroundColor = Color.LerpUnclamped (currentColor, mainColors[2], time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
		}
		
		
		return true;
		
		
	} 







}
	
	
	
	
	
	
	
	

