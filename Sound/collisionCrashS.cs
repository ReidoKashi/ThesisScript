using UnityEngine;
using System.Collections;

public class collisionCrashS : MonoBehaviour 
{
	[Header("LOGIC")]
	public musLang _feedBack;
	public NewTransfomrShip _reset;
	Camera cam;
	[Space(10)]
	
	[Header("BACKDROP")]
	public float time = .25f;
	public float gradate = .01f;
	public float duration = .15f;
	public Color resetBackColor;
	[Space(10)]
 
	public float Acel;
	public float Dec;
	public Vector3 playerVec;
	public Rigidbody playerRigid;
	public int speedLev;
	public int limit = 3;
	public int addMe = 1;
	public GameObject particleSys;
	public Camera Cam;
	public CrashAmount _crashInstance;
	public winState _winState;

	public IEnumerator resetMeCo ()
	{ 
		
		
		
		Color currentColor = Cam.backgroundColor;
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) {
			
			
			Cam.backgroundColor = Color.LerpUnclamped (currentColor, resetBackColor, time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
		}
		return true;
	}
		
		
		
		
		
		void OnTriggerEnter(Collider col)
		{ 
			StartCoroutine (resetMeCo ());

			if (col.gameObject.tag == "Square") 
		{_feedBack.endMusicSuccess (); 
			particleSys.GetComponent<PassGate>().particleS();
			_winState.incrementWin();

				
		} else if (col.gameObject.tag == "Triangle" || col.gameObject.tag == "Circle" || col.gameObject.tag == "RANDOM" ) {
			_feedBack.endMusicFailure ();
			_crashInstance.GetComponent<CrashAmount>().gO();
				playerRigid.AddForce(playerVec * Dec);
				
				
			}
			
		}
	void OnTriggerExit(Collider col)
	{ _reset.resetPlayer ();
	}
		
		
	
}
