using UnityEngine;
using System.Collections;

public class phaseGateS : MonoBehaviour {

	public float Acel;
	public float Dec;
	public Vector3 playerVec;
	public Rigidbody playerRigid;
	public int speedLev;
	public int limit = 3;
	public int addMe = 1;
	public bool maxGate;
	public GameObject particleSys;
	public Camera Cam;
	public CrashAmount _crashInstance;
	public GameObject liveCount;
	
	// Use this for initialization
	void Start () {
		
		maxGate = false;
		
	}
	
	
	void OnTriggerEnter(Collider col)
	{ //gate trigger checks for proper gate 
		if (col.gameObject.tag == "Square") 
		{ Debug.Log("boost_square");
			//call function Particle system from particle in camera
			particleSys.GetComponent<PassGate>().particleS();
			Cam.GetComponent<BackGround>().callBackS();	
			// if proper gate accelerate
			if (maxGate == false)
			{
				playerRigid.AddForce(playerVec * Acel);
			} else {
				Debug.Log("reporting back no boost");}
			
		} else if (col.gameObject.tag == "Triangle" || col.gameObject.tag == "Circle") {
			Debug.Log ("wrong gate!!");
			// if not proper gate slow down
			_crashInstance.GetComponent<CrashAmount>().gO();
			playerRigid.AddForce(playerVec * Dec);
			maxGate = false;
			
			//speedLev = 0;
		}
		
	}
	
	public void GateSuspend(){
		maxGate = true;
	}
}
