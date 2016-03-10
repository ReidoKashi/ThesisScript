using UnityEngine;
using System.Collections;

public class CrashAmount : MonoBehaviour {
	public GameObject guiInterface;
	public GameObject explodeAnim;
	public int crashNum;	
	public int gameOver;
	public int phaseNum;
	private bool flipper;
	void Start () {
		int gameOver = 0;
		flipper = false;
	}


	public void resetGo() {
		gameOver = 0;


	}
	public void resetPhase() {
		phaseNum = 0;
		
		
	}

	public void gO()
		{
		if (!flipper) 
		{flipper = true;
			StartCoroutine (gameOverMethod ());
		}
	}

	public IEnumerator gameOverMethod(){///_____________________________________________________inworks

		Debug.Log ("gameover method called");
		if (gameOver == 2) 
		{   resetGo();
			explodeAnim.GetComponent<Animator>().SetBool("shipExplode",true);
			yield return new WaitForSeconds(3f);
			Application.LoadLevel(0);

		}
		gameOver++;
		yield return new WaitForSeconds(5f);
		flipper = false;
		
	}


	public void openPhase()
	{
		if (!flipper) 
		{flipper = true;
			StartCoroutine (phaseMethod ());
		}
	}

	public IEnumerator phaseMethod(){///_____________________________________________________inworks
		
		Debug.Log ("gameover method called");
		if (phaseNum == 5) 
		{   resetGo();
			explodeAnim.GetComponent<Animator>().SetBool("shipExplode",true);
			yield return new WaitForSeconds(3f);
			Application.LoadLevel(0);
			
		}
		gameOver++;
		yield return new WaitForSeconds(5f);
		flipper = false;
		
	}





}





