using UnityEngine;
using System.Collections;

public class destroySelf : MonoBehaviour {
	private float destroyNum = .2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	}



	IEnumerator desRoute(){
		yield return new WaitForSeconds (destroyNum);
		Destroy (gameObject,destroyNum);

	
	
	}

}
