using UnityEngine;
using System.Collections;

public class morphSystem : MonoBehaviour {
	Animator morphAnim;
	// Use this for initialization
	void Start () {
		morphAnim = GetComponent<Animator> ();
	}
	
	public void animYel(){
		StartCoroutine (coYellow());
	}



	public void animPin(){
		
		
		StartCoroutine (coPink());
	}

	public void animGrn(){
		
		StartCoroutine (coGreen());

	}

	void animReset(){

		morphAnim.GetComponent<Animator> ().SetInteger ("animMorph", 0);


	}


	// coroutines here because morphing animation system: needs time delays to stop morphs
	IEnumerator coYellow(){
		morphAnim.GetComponent<Animator> ().SetInteger ("animMorph", 3);
		yield return new WaitForSeconds (1f);
		animReset ();
	}
	IEnumerator coGreen(){
		morphAnim.GetComponent<Animator> ().SetInteger ("animMorph", 2);
		yield return new WaitForSeconds (1f);
		animReset ();
	}
	IEnumerator coPink(){
		morphAnim.GetComponent<Animator> ().SetInteger ("animMorph", 1);
		yield return new WaitForSeconds (1f);
		animReset ();
	}



}
