﻿using UnityEngine;
using System.Collections;

public class phaseGateT : MonoBehaviour {
	public Increment _phaseChange;
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
	Animator anim;

	void Start()
	{anim = GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider col)
	{ //gate trigger checks for proper gate 
		if (col.gameObject.tag == "Triangle") 
		{ 
			//call function Particle system from particle in camera
			_phaseChange.phaseActivate();
			particleSys.GetComponent<PassGate>().particleS();
			//anim.SetBool("pass",true);

		
				playerRigid.AddForce(playerVec * Acel);
		
			} else if (col.gameObject.tag == "Circle") {

			_phaseChange.phaseAlt ();
			particleSys.GetComponent<PassGate> ().particleS ();
		
		
		}else{

			// if not proper gate slow down
			_crashInstance.GetComponent<CrashAmount>().gO();
			playerRigid.AddForce(playerVec * Dec);

		}
		
	}
	

	
}

