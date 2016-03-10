using UnityEngine;
using System.Collections;

public class Crash : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void crashAnim(){
		anim.GetComponent<Animation> ().Play ("hit_Back");

	}
}
