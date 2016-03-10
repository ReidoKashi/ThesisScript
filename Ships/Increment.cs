using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Increment : MonoBehaviour {
	public int finalRes = 0;
	public AudioMixerSnapshot defaultSnap;
	public Canvas guiInterface;
	public int inc = 0;
	public int resInc = 0;
	private bool resFlip = false;
	public rescueTalk _talkToRescue;
	private GameObject[] gates = new GameObject[3];
	public bool boolGate=false;
	public GameObject triangleGate, circleGate, squareGate;
	public Transform PlayerPos;
	public Vector3 speedLv_1;
	public Vector3 speedLv_2;
	public Vector3 speedLv_3;
	public Vector3 speedLv_4;
	public int gameOver;

	//public collisionCrash _scriptTalk; 
	// Use this for initialization
	void Start () {
		gates [0] = triangleGate;
		gates [1] = circleGate;
		gates [2] = squareGate; 
		int gameOver = 0;
		defaultSnap.TransitionTo(0);
	}

	void Update(){
			
			
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider Col)
	{

		if (Col.gameObject.tag == "Melody Gate" && inc <= 3  ) {
			//inc++; Sets the gate to bring in the limits will code this logic later
			Debug.Log("hit");

			//Application.LoadLevel(0);
			while (!boolGate) {
				boolGate = true;
				StartCoroutine(resIncCo());
				Debug.Log (boolGate);
				int randomNum = Random.Range(0,3);

				Transform gateInstan = (Transform)Instantiate(gates[randomNum],PlayerPos.position + speedLv_1,PlayerPos.rotation);
					StartCoroutine ( resIncCo() );
			}

		} else {

			//GetComponent<collisionCrash>().GateSuspend();

			//maxGate = true;
			Debug.Log ("Test is calling out gate suspend");
		}

	}

	void OnTriggerExit(Collider Ex)
	{ Debug.Log ("fixing boolGate");
		if (boolGate = true) {

			boolGate = false;

		}
	}
		 IEnumerator resIncCo()
	
	{  
		Debug.Log (resInc);
			resInc++;

		if (resInc == finalRes) 
		{
			_talkToRescue.callRescue_1 ();
		}

			yield return new WaitForSeconds (2f);


	}


}

