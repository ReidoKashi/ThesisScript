using UnityEngine;
using System.Collections;

public class playerLogic : MonoBehaviour {
	[Header("Debug")]
	public bool rayOn;

	[Header("Logic")]
	public lang _logic;
	public gateLogic _gateLogic;
	
	[Header("Options")]
	public float rayDist = 200f;
	public Vector3 rayDir;
	public Transform playerPosition;
	public float newClampedNum;

	[Header("Raycast")]
	public float lerpedNum;
	public float phaseGradate;
	public float returnedSnap;
	public float rayLogic;

	[Header("Flippers")]
		public bool rayFlip = false; //flipper for rayacast
		public bool gradateFlip = true; // flipper for gradiant volume change

void Awake()
	{
		 rayDir = transform.position + Vector3.forward;
		 lerpedNum = 0;
	}

	public void rayInverse()
	{Debug.Log ("hey rayflip is flipped");
		if (!rayFlip) {
			rayFlip = true;

		} else if(rayFlip){
			rayFlip = false;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log (gradateFlip+" gradedate flip is now ");
		//Raycast
		Ray soundRay = new Ray (playerPosition.position, rayDir);
		RaycastHit targetHit = new RaycastHit ();
		Physics.Raycast (playerPosition.position, rayDir, out targetHit, rayDist);
		float finalParam = targetHit.distance;

		  if (!rayFlip) 
		{
			Debug.DrawRay(playerPosition.position,rayDir*rayDist, Color.red );
			if (Physics.Raycast (playerPosition.position, rayDir, out targetHit, rayDist)) {
				//rayFlip = true; //flip the ray switch on
				if (targetHit.transform.tag == "Triangle")
				{//rayLogic = (Mathf.Abs((targetHit.distance / 200f) + -.9f));
					_logic.sonicIncrement(1);
					_logic.enabled = false;
					_logic.enabled = true;

					Debug.Log ("triangle is sending back a signal");

				} else if (targetHit.transform.tag == "Circle")
				{//rayLogic = (Mathf.Abs((targetHit.distance / 200f) + -.9f));

					_logic.sonicIncrement(2);
					Debug.Log ("circle is sending back a signal");
					_logic.enabled = false;
					_logic.enabled = true;
					//_gateLogic.colorJump(2);
				}else if (targetHit.transform.tag == "Square")
				{//rayLogic = (Mathf.Abs((targetHit.distance / 200f) + -.9f));
					_logic.sonicIncrement(0);
					Debug.Log ("square is sending back a signal");
					_logic.enabled = false;
					_logic.enabled = true;
				};

				//clampSnapShot (targetHit.distance);
			}
		}

			if(!gradateFlip)
			{
				if (Physics.Raycast (playerPosition.position, rayDir, out targetHit, 200f)) 
				{

					
					
				}

			

			}

	
	}
	float clampSnapShot(float snapShot)
		{  
		//Debug.Log (" snapshot at the begging of while loop " + snapShot); COUNTER FOR SNAPSHOT
		returnedSnap = snapShot;
			gradateFlip = false;
			return returnedSnap;

		}
//		while(newClampedNum<1)
//		{  Debug.Log( "snapshot at the begging of while loop" + snapShot );
//			newClampedNum = newClampedNum / 200f;
//			Debug.Log (newClampedNum + "is the new clamped number");
//			Debug.Log(snapShot + "snapshot number");
//		}
	}




