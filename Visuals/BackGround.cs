using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {
	// Color Arrays
	//public Color[] Gate_Colors;
	// Three gate colors
	public Color currentColor;
	public int phaseNum;
	public Color[] phase_color = new Color[8];
	public Color gameOverColor;
	public Color[] phase_adapt = new Color[8];
	// Variables to change Lurp
	public float duration = 0.02f;
	public float gradate = 2;
	//public float time = .2f;
	public float wasOne= 1f;
	public Increment _phaseReflection; // this is reflecting the phase number to bring to this script
	// Calling Camera
	public int nuM = 0;
	public float time;
	public Camera cam;


public void muteBackground(){
	
	StartCoroutine (mute());
}
IEnumerator mute()
{
		Color currentColor = cam.backgroundColor;
		float time = .1f;
		float logic = gradate / duration;
		while (time < 1) {

			cam.backgroundColor = Color.LerpUnclamped (currentColor, gameOverColor, time);
			time += .2f;
			yield return new WaitForSeconds (.2f);
		}
}

		public void phaseLurp()
	{
		StartCoroutine (phaseLurpC ());
	}
	public IEnumerator phaseLurpC()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[0],time);
		yield return new WaitForSeconds(1);
	}


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
				
			cam.backgroundColor = Color.LerpUnclamped(currentColor,gameOverColor,time);
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
				
			cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[0],time);
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
				
			cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[0],time);
				time += logic;
				yield return new WaitForSeconds(gradate);
				Debug.Log ("backLurpS");
				
			}
			return true;
		}

	

	public void phaseLurp_1()
	{
		StartCoroutine (phaseLurpC_1 ());
	}
	public IEnumerator phaseLurpC_1()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[1],time);
		yield return new WaitForSeconds(1);

	}


	public void phaseLurp_2()
	{
		StartCoroutine (phaseLurpC_2 ());
	}
	public IEnumerator phaseLurpC_2()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[2],time);
		yield return new WaitForSeconds(1);
		
	}

	public void phaseLurp_3()
	{
		StartCoroutine (phaseLurpC_3 ());
	}
	public IEnumerator phaseLurpC_3()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[3],time);
		yield return new WaitForSeconds(1);
		
	}

	public void phaseLurp_4()
	{
		StartCoroutine (phaseLurpC_4 ());
	}
	public IEnumerator phaseLurpC_4()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[4],time);
		yield return new WaitForSeconds(1);
	}

	public void phaseLurp_5()
	{
		StartCoroutine (phaseLurpC_5 ());
	}
	public IEnumerator phaseLurpC_5()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[6],time);
		yield return new WaitForSeconds(1);
		
	}

	public void phaseLurp_6()
	{
		StartCoroutine (phaseLurpC_6 ());
	}
	public IEnumerator phaseLurpC_6()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[6],time);
		yield return new WaitForSeconds(1);
		
	}

	public void phaseLurp_7()
	{
		StartCoroutine (phaseLurpC_7 ());
		Debug.Log("tesat co routine added");
	}
	public IEnumerator phaseLurpC_7()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[7],time);
		yield return new WaitForSeconds(1);
		
	}


	public void phaseLurp_8()
	{
		StartCoroutine (phaseLurpC_8 ());
	}
	public IEnumerator phaseLurpC_8()
	{
		Color currentColor = cam.backgroundColor;
		cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_color[8],time);
		yield return new WaitForSeconds(1);
		
	}








	public void phaseLerpAlt()
	{
		StartCoroutine (phaseLerpAltC ());
	}


	public IEnumerator phaseLerpAltC()
	{
		Color currentColor = cam.backgroundColor;
		float time = .5f;
		float logic = gradate / duration;
		while (time < 1) 
		{
			
			//time += Time.deltaTime* 5;
			//time += Time.time;
			
			cam.backgroundColor = Color.LerpUnclamped(currentColor,phase_adapt[_phaseReflection.phaseLevel],time);
			time += logic;
			yield return new WaitForSeconds(gradate);
			Debug.Log ("backLurpS");
			
		}
		return true;
	}





















}
