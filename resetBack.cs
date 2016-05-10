using UnityEngine;
using System.Collections;

public class resetBack : MonoBehaviour
{
	[Header("LOGIC")]
	public float
		gradate = .01f;
	public float duration = .15f;
	public Camera cam;
	[Tooltip("1 pink 2 green 3 yellow")]
	public int choice;

	[Header("COLORS")]
	public Color
		resetBackColor;
	[Header("SOUND")]
	public AudioSource
		pink;
	public AudioSource green;
	public AudioSource yellow;
	public AudioSource damage;
	public AudioSource match;

	void OnTriggerEnter (Collider col)
	{
		
		if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Triangle") {
			switchCall (choice);
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
			

			cam.backgroundColor = Color.LerpUnclamped (currentColor, resetBackColor, time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
		}
		
		
		return true;
		
		
	}

	void switchCall (int choice)
	{
		switch (choice) 
		{
		case 1:
			pink.Play ();
			resetMe ();
			break;

		case 2: 
			green.Play ();
			resetMe ();
			break;

		case 3: 
			yellow.Play ();
			resetMe ();
			break;
	
		}
	}
}
