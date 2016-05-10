using UnityEngine;
using System.Collections;

public class t1 : MonoBehaviour {
	[Header("LOGIC")]
	public Increment _increment;
	public GameObject particleSys;
	public pointSystem _point;
	public CrashAmount _crashInstance;
	public bool extraPoint;
	void OnTriggerEnter(Collider col)
	{ //gate trigger checks for proper gate 
		//_playLogic.rayInverse ();
		if (extraPoint) {
			if (col.gameObject.tag == "Triangle") {
				_increment.gateSound ();
				particleSys.GetComponent<PassGate> ().particleS ();
				_point.EarnAPoint();

				//anim.SetBool("pass",true);
				
				
			} else if (col.gameObject.tag == "Circle") {
				
				_increment.gateSound ();
				particleSys.GetComponent<PassGate> ().particleS ();
				_point.earnFive();
				
			} else if (col.gameObject.tag == "Square" ) {
				
				// if not proper gate slow down
				_crashInstance.GetComponent<CrashAmount> ().gO ();
				
				
				
			}
		} else {
			
			if (col.gameObject.tag == "Triangle") 
				
			{
				_increment.gateSound();
				particleSys.GetComponent<PassGate>().particleS();
				_point.EarnAPoint();
								
			} else if (col.gameObject.tag == "Square" || col.gameObject.tag == "Circle"){
				
				// if not proper gate slow down
				_crashInstance.GetComponent<CrashAmount>().gO();
				
				
				
			}
			
		}
		
	}
}
