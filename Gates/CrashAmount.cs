using UnityEngine;
using System.Collections;

public class CrashAmount : MonoBehaviour {
	public GameObject guiInterface;
	public GameObject explodeAnim;
	public GameObject playerShip;
	public Transform resetPosition;
	public int gameOver;
	public Increment _increment;
	public healthBarSystem _healthBar;
	public BackGround _loseBackground;



	private bool flipper;
	void Start () {
		int gameOver = 0;
		flipper = false;
	}


	public void resetGo() {
		gameOver = 0;


	}


	public void gO()// method starts crash animation + slows down vehicle 
		{

		guiInterface.GetComponent<Animator> ().SetBool ("damage", true);
		if (!flipper) 
		{flipper = true;
			StartCoroutine (gameOverMethod ());

		}
	}

	public IEnumerator gameOverMethod(){///_____________________________________________________inworks




		if (gameOver == 2) 
		{   
			resetGo();
			explodeAnim.GetComponent<Animator>().SetBool("shipExplode",true);
			//Time.timeScale = .2f;
			_loseBackground.muteBackground();
			playerShip.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1) * 1000f,ForceMode.Force);
			yield return new WaitForSeconds(7f);
			Application.LoadLevel(0);

		}
		gameOver++;
		_healthBar.showHealth();
		//guiInterface.GetComponent<Animator> ().SetBool ("damage", true);
		//yield return new WaitForSeconds (1);

		yield return new WaitForSeconds(2f);
		guiInterface.GetComponent<Animator> ().SetBool ("damage", false);
		flipper = false;
	}








}





