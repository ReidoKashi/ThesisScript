using UnityEngine;
using System.Collections;

public class shipDrive : MonoBehaviour {
	public float initPush;
	public float cruise;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (new Vector3 (0, 0, cruise), ForceMode.Force);
	}

}
