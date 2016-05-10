using UnityEngine;
using System.Collections;

public class camZoom : MonoBehaviour {
	public Camera cam;
	public float end;
	public float start;
	public float time;
	public float gradate;
	public float increment;

	// Update is called once per frame
  void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Triangle" || col.gameObject.tag == "Triangle"||col.gameObject.tag == "Circle"||col.gameObject.tag == "RANDOM") 
		
		{
			updateCamera();
		}
	}

	void updateCamera(){


		StartCoroutine (cameraLerp ());
	}

	IEnumerator cameraLerp()
	{	

		while (time<1) {

				cam.orthographicSize = Mathf.LerpUnclamped (start, end, time);
				time += increment;
				yield return new WaitForSeconds(gradate);
			
		}
		yield return new WaitForSeconds(.2f);

		}

		
		
		
		
	}




