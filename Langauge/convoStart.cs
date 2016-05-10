using UnityEngine;
using System.Collections;

public class convoStart : MonoBehaviour {
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
	public AudioSource pinkAB;
	public AudioSource pinkBA;
	public AudioSource greenAB;
	public AudioSource greenBA;
	public AudioSource yellowAB;
	public AudioSource yellowBA;
	public AudioSource damage;
	public AudioSource match;




	void OnTriggerEnter (Collider col)
	{
		
		if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square" || col.gameObject.tag == "RESET" || col.gameObject.tag == "Player") {
			resetMe();
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

}
