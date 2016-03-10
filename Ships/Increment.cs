using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Increment : MonoBehaviour {
	//this is a public variable that will speak with the background script
	public BackGround _phaseChange;
	public ParticleSystem speedUp;
	public ParticleSystem speedUp2;
	public ParticleSystem speedUp3;
	public int finalRes = 0;
	public AudioMixerSnapshot defaultSnap;
	public Canvas guiInterface;
	public int inc = 0;
	public int resInc = 0;
	private bool resFlip = false;
	public rescueTalk _talkToRescue;
	private GameObject[] gates = new GameObject[3];
	private GameObject[] phase_Gates = new GameObject[3];
	public bool boolGate=false;
	public GameObject triangleGate, circleGate, squareGate, phase_SquareGate, phase_TriangleGate, phase_CircleGate;
	public Transform PlayerPos;
	public Vector3 speedLv_1;
	public Vector3 speedLv_2;
	public Vector3 speedLv_3;
	public Vector3 speedLv_4;
	public int gameOver;
	private int phaseCounter = 0;
	private int phaseLevel = 0;

	//public collisionCrash _scriptTalk; 
	// Use this for initialization
	void Start () {
		gates [0] = triangleGate;
		gates [1] = circleGate;
		gates [2] = squareGate; 
		phase_Gates [0] = phase_SquareGate; 
		phase_Gates [1] = phase_TriangleGate; 
		phase_Gates [2] = phase_CircleGate; 
		int gameOver = 0;
		defaultSnap.TransitionTo(1);
	}

	void Update(){

		
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider Col)
	{

		if (Col.gameObject.tag == "Melody Gate" && inc <= 3  ) {
			//inc++; Sets the gate to bring in the limits will code this logic later


			Debug.Log ("phase has hit " + phaseCounter);
			//Application.LoadLevel(0);
			while (!boolGate) {
				boolGate = true;

				Debug.Log (boolGate);
				int randomNum = Random.Range(0,3);
				int randomPhase = Random.Range(0,3);
				if (phaseCounter >= 5){
					Debug.Log ("hello I'm the phaseGate");
					phaseCounter = 0;
					Transform gateInstan = (Transform)Instantiate(phase_Gates[randomPhase],PlayerPos.position + speedLv_1,PlayerPos.rotation);

				} else {
					StartCoroutine(phaseCoIncrement());
				Transform gateInstan = (Transform)Instantiate(gates[randomNum],PlayerPos.position + speedLv_1,PlayerPos.rotation);


				}
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
	IEnumerator phaseCoIncrement(){
		//increments the phase gates
		phaseCounter++;
		phaseLevel++;


		yield return new WaitForSeconds (2f);
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

	void phaseActivate() {
		if (phaseLevel <=5)
		{
			_phaseChange.Lurp_C();


		}



}

}