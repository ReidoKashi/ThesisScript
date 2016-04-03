using UnityEngine;
using System.Collections;

public class collisionCrashC : MonoBehaviour {
	public Increment _increment;
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
	//Animator anim;

	
	void Start()
	{//anim = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider col)
	{ //gate trigger checks for proper gate 
		if (col.gameObject.tag == "Circle") 

		{
			_increment.gateSound();
			particleSys.GetComponent<PassGate>().particleS();
			playerRigid.AddForce(playerVec * Acel);

			//anim.SetBool("pass",true);

			
		} else if (col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square"){

			// if not proper gate slow down
			_crashInstance.GetComponent<CrashAmount>().gO();
			playerRigid.AddForce(playerVec * Dec);


		}
		
	}
	
}

