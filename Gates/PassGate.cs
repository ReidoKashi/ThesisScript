using UnityEngine;
using System.Collections;

public class PassGate : MonoBehaviour {
	public GameObject particleSys;
	// Use this for initialization
	void Start () {

		particleSys.GetComponent<ParticleSystem>().Stop(); 
	}
	
	// Update is called once per frame



	public void particleS(){

		particleSys.GetComponent<ParticleSystem>().Play();

		
	}


}
