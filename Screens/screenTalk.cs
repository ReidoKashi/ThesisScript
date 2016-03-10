using UnityEngine;
using System.Collections;

public class screenTalk : MonoBehaviour {

	public GameObject guiInterface;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		guiInterface.GetComponent<Animator> ().SetBool ("fadeScreen", true);
//		guiInterface = new Rect (0f, 0f, Screen.width, Screen.height);
	}
}
