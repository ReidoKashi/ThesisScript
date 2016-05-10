using UnityEngine;
using System.Collections;

public class c1 : MonoBehaviour {
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
			if (col.gameObject.tag == "Circle") {
				_increment.gateSound ();
				particleSys.GetComponent<PassGate> ().particleS ();
				_point.EarnAPoint();
				
				//anim.SetBool("pass",true);
				
				
			} else if (col.gameObject.tag == "Square") {
				
				_increment.gateSound ();
				particleSys.GetComponent<PassGate> ().particleS ();
				_point.earnFive();
				
				
			} else if (col.gameObject.tag == "Triangle" ) {
				
				// if not proper gate slow down
				_crashInstance.GetComponent<CrashAmount> ().gO ();
				
				
				
			}
		} else {
			
			if (col.gameObject.tag == "Circle") 
				
			{
				_increment.gateSound();
				particleSys.GetComponent<PassGate>().particleS();
				_point.EarnAPoint();
				
				//anim.SetBool("pass",true);
				
				
			} else if (col.gameObject.tag == "Triangle" || col.gameObject.tag == "Square"){
				
				// if not proper gate slow down
				_crashInstance.GetComponent<CrashAmount>().gO();
				
				
				
			}
			
		}
		
	}
}
