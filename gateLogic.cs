using UnityEngine;
using System.Collections;

public class gateLogic : MonoBehaviour {
	[Header("Logic")]
	public lang _logic;
	public playerLogic _playLogic;
	Camera cam;

	[Header("Options")]
	public bool phaseEnabled;
	public bool circleEnabled;
	public bool triangleEnabled;
	public bool squareEnabled;

	[Header("Gates")]
	public Color[] mainColors = new Color[3];
	public GameObject[] gates = new GameObject[3];
	public GameObject[] phaseGates = new GameObject[3];
	public AudioSource[] gateComp = new AudioSource[3];
	public float gradate;
	public float duration;
	public float time;




	public void sonicIncrement(int passLogic)
	{	_playLogic.rayInverse ();

		if(!gateComp [passLogic].isPlaying)
		{ Debug.Log (passLogic + " passing in pass logic "); 
			//gateComp [1].volume = passLogic;

			colorJump(passLogic);
		}
		
	}
	
	public void colorJump(int passLogic)
	{Debug.Log ("we are here");
		StartCoroutine (colorJumpC(passLogic));

	}
	
	public IEnumerator colorJumpC(int passLogic)
	{
		Color currentColor = cam.backgroundColor;
		
		
		float logic = gradate / duration;
		while (time < 1) 
		{
			
			//time += Time.deltaTime* 5;
			//time += Time.time;
			
			cam.backgroundColor = Color.LerpUnclamped(currentColor,mainColors[passLogic],time);
			time += logic;
			yield return new WaitForSeconds(gradate);
						
		}
		return true;
	}

	void OnTriggerEnter(Collider col){

//	if (col.gameObject.tag == "Circle") {
//		//call function Particle system from particle in camera
//		particleSys.GetComponent<PassGate> ().particleS ();
//		_logic.phaseActivate ();
//		//anim.SetBool ("pass", true);
//		
//		
//		playerRigid.AddForce (playerVec * Acel);
//		
//	} else if (col.gameObject.tag == "Square") {
//		
//		_logic.phaseAlt ();
//		particleSys.GetComponent<PassGate> ().particleS ();
//		
//		
//	}else{
//		
//		// if not proper gate slow down
//		_crashInstance.GetComponent<CrashAmount>().gO();
//		playerRigid.AddForce(playerVec * Dec);
//		
//		}
//		
//	}
	}
}


