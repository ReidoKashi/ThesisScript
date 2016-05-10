using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Increment : MonoBehaviour {
	//this is a public variable that will speak with the background script
	public BackGround _phaseChange;
	public AudioSource SFX_Player;
	public AudioSource altAud_1;
	public AudioSource altAud_2;
	public AudioSource altAud_3;
	public AudioSource altAud_4;
	public AudioSource altAud_5;
	public AudioSource altAud_6;
	public AudioSource altAud_7;
	public AudioSource altAud_8;
	public AudioSource altAud_9;
	public AudioSource altAud_10;
	public AudioSource compliAud_1;
	public AudioSource compliAud_2;
	public AudioSource compliAud_3;
	public AudioSource compliAud_4;
	public AudioSource compliAud_5;
	public AudioSource[] gateSfx = new AudioSource[2];
	public AudioClip morphFX1;
	public AudioClip morphFX2;
	public AudioClip comp1;
	public AudioClip comp2;
	public AudioClip comp3;
	public ParticleSystem speedUp;
	public ParticleSystem speedUp2;
	public ParticleSystem speedUp3;
	public int finalRes = 0;
	public AudioMixerSnapshot defaultSnap;
	public Canvas guiInterface;
	public int inc = 0;
	public int resInc = 0;
	private bool resFlip = false;
	private GameObject[] gates = new GameObject[6];
	private GameObject[] phase_Gates = new GameObject[6];
	public GameObject[] challenge_Gates = new GameObject[3];
	public bool boolGate;
	public bool boolGateR;
	public GameObject triangleGate, circleGate, squareGate, phase_SquareGate, phase_TriangleGate, phase_CircleGate;
	public Transform PlayerPos;
	public Vector3 speedLv_1;
	public Vector3 speedLv_2;
	public Vector3 speedLv_3;
	public Vector3 speedLv_4;
	private Vector3[] speeds = new Vector3[3];
	public int gameOver;
	private int phaseCounter = 0;
	public int phaseLevel = 0;
	public GameObject initSpeed;
	public GameObject secondSpeed;
	public GameObject thirdSpeed;
	public GameObject trailSystem;
	public winState _winState;
	public bool challengeOn;
	public bool phaseDebug;
	public bool phaseOff; // this will turn off the phasegate functionallity


	//public collisionCrash _scriptTalk; 
	// Use this for initialization
	void Start () {
		speeds [0] = speedLv_2;
		speeds [1] = speedLv_3;
		speeds [2] = speedLv_4;
		gates [0] = triangleGate;
		gates [1] = circleGate;
		gates [2] = squareGate; 
		gates [4] = triangleGate;
		gates [3] = circleGate;
		gates [5] = squareGate;
		phase_Gates [0] = phase_SquareGate; 
		phase_Gates [1] = phase_TriangleGate; 
		phase_Gates [2] = phase_CircleGate;
		phase_Gates [3] = phase_CircleGate;
		phase_Gates [4] = phase_SquareGate;
		phase_Gates [5] = phase_TriangleGate;
		int gameOver = 0;
		defaultSnap.TransitionTo(1);
		boolGateR = false;

	}

	public void gateSound()
		{
		int rndSnd = Random.Range (0, 1);
		gateSfx[rndSnd].Play ();
		Debug.Log ("playing gate");

		}

	// Update is called once per frame
	void OnTriggerEnter(Collider Col)
	{

		if (Col.gameObject.tag == "Circle" || Col.gameObject.tag == "Triangle" || Col.gameObject.tag == "Square" || Col.gameObject.tag == "Melody Gate") {
			//inc++; Sets the gate to bring in the limits will code this logic later
			if (phaseOff) // this will turn off the phase gate functionallity
			{phaseCounter = 0;
			}

			Debug.Log ("phase has hit " + phaseCounter);
			if (!boolGate) {
				boolGate = true;

				Debug.Log (boolGate);
				int randomNum = Random.Range(0,5);

				if (phaseCounter >= 5 || phaseDebug){
					phaseCounter = 0;
					phaseLevel++;
					GameObject gateInstan = (GameObject)Instantiate(phase_Gates[randomNum],PlayerPos.position + speedLv_1,PlayerPos.rotation);

					//2 circle

				} else {
					if(!boolGateR)
					{StartCoroutine(callRegGate());
					}

				}
			}

		} else {


			Debug.Log ("Test is calling out gate suspend");
		}

	}

	void OnTriggerExit(Collider Ex)
	{ Debug.Log ("fixing boolGate");
		if (boolGateR) 
		{boolGateR = false;
		} //put it in an object after it
		if (boolGate = true) {

			boolGate = false;

		}
	}
	IEnumerator callRegGate()
	{
		if(!boolGateR) 
		{
			int randomNum = Random.Range (0, 5);
			if(!boolGateR)
			{

			GameObject gateInstan_R = (GameObject)Instantiate (gates[randomNum], PlayerPos.position + speedLv_1, PlayerPos.rotation);
			}
			boolGateR = true;
			phaseCounter++;




			if(challengeOn)// if challange mode is on

			{switch(randomNum)
				{
				case 2:
				GameObject challengeInstan = (GameObject)Instantiate (challenge_Gates[randomNum], PlayerPos.position + speedLv_2, PlayerPos.rotation);
				GameObject challengeInstan_2 = (GameObject)Instantiate (challenge_Gates[randomNum], PlayerPos.position + speeds[Random.Range(1,2)], PlayerPos.rotation);
				break;
				
				case 1:
				GameObject challengeInstan_3 = (GameObject)Instantiate (challenge_Gates[randomNum], PlayerPos.position + speeds[randomNum], PlayerPos.rotation);
				break;

				case 0:
				break;
				
				default:
				break;

				}
					//return
			}

			//2 is sauare
			yield return new WaitForSeconds (2f);
		}
	}

		
	public void phaseActivate() {
		switch (phaseLevel) {
		case 9:
			_winState.playWin();
			break;
		case 8:
			compliAud_1.Play ();
			_phaseChange.phaseLurp_7();
			break;
		
		case 7:
			compliAud_3.Play ();
			_phaseChange.phaseLurp_6();
			break;

		case 6:
			compliAud_2.Play ();
			_phaseChange.phaseLurp_5();
			break;
		case 5:

			compliAud_5.Play ();
			_phaseChange.phaseLurp_4();
			break;
		case 4:
			compliAud_4.Play ();
			_phaseChange.phaseLurp_3();

			break;
		case 3:
			compliAud_3.Play ();
			_phaseChange.phaseLurp_2();
		
			//these three methods activate speed aesthetics like background movment, and trailrenderer
			trailSystem.GetComponent<Animator>().SetBool("trail",true);
		//	initSpeed.SetActive(false);
		//	secondSpeed.SetActive(true);
			break;

		case 2:
			compliAud_2.Play ();
			_phaseChange.phaseLurp_1();

			break;

		case 1:
			compliAud_1.Play ();
			_phaseChange.phaseLurp();
			break;
		default:
			compliAud_1.Play ();
			_phaseChange.phaseLurp();
			break;
		}

	}

	public void phaseAlt() {
		switch (phaseLevel) {
		case 9:
			_winState.playWin();
			break;
		case 8:
			altAud_9.Play ();
			_phaseChange.phaseLerpAlt();
			break;
			
		case 7:
			altAud_8.Play ();
			_phaseChange.phaseLerpAlt();
			break;
			
		case 6:
			altAud_7.Play ();
			_phaseChange.phaseLerpAlt();
			break;
		case 5:
			
			altAud_6.Play ();
			_phaseChange.phaseLerpAlt();
			break;
		case 4:
			altAud_5.Play();
			_phaseChange.phaseLerpAlt();
			
			break;
		case 3:
			altAud_4.Play ();
			_phaseChange.phaseLerpAlt();
			
			//these three methods activate speed aesthetics like background movment, and trailrenderer
			trailSystem.GetComponent<Animator>().SetBool("trail",true);
			//	initSpeed.SetActive(false);
			//	secondSpeed.SetActive(true);
			break;
			
		case 2:
			altAud_3.Play ();
			_phaseChange.phaseLerpAlt();
			
			break;
			
		case 1:
			altAud_2.Play ();
			_phaseChange.phaseLerpAlt();
			break;
		default:
			altAud_1.Play ();
			_phaseChange.phaseLerpAlt();
			break;
		}
		
	}


}