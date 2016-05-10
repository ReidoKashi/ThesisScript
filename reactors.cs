using UnityEngine;
using System.Collections;

public class reactors : MonoBehaviour {
	[Header("LOGIC")]
	public lang _language;
	public Camera cam;

	[Header("VARS")]
	[Tooltip("1pink 2green 3yellow")]
	public int levelchange;
	public float time = .25f;
	public float gradate = .01f;
	public float duration = .15f;
	public int incre = 0;
	[Header("COLORS")]
	
	public Color[] colors = new Color[4];
	[Header("EFFECTS")]
	public GameObject particleSys;

	[Header("SFX")]
	public AudioSource pink;
	public AudioSource green;
	public AudioSource yellow;
	public AudioSource damage;
	public AudioSource match;
	void OnTriggerStay(Collider col)
	{

		if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Triangle" || col.gameObject.tag == "Triangle"){
			methodCall (levelchange);
		}
	}
	
	public void methodCall(int levelchange)
	{
		
		switch (levelchange) 
		{
		case 1:

			Debug.Log("method 1 is being collaced pulse");
					if (Input.GetKey(KeyCode.A))
				{ 			_language.colorJump();

				match.Play();
							//pink.Play();			
				}
			else if(Input.GetKey(KeyCode.S))
				{ damage.Play();
				wrongChoice(1);
				}
			 else if (Input.GetKey(KeyCode.W))
				{damage.Play();
				wrongChoice(1);
				}
				
			break;
			
		case 2:
			Debug.Log("method is being collaced pulse");
			if (Input.GetKey(KeyCode.W))
			{ 	_language.colorJump2();
				match.Play();
			}
			 else if(Input.GetKey(KeyCode.S))
				{damage.Play();
				wrongChoice(1);
				}
			 else if (Input.GetKey(KeyCode.W))
			{	damage.Play();
				wrongChoice(1);
			}
				break;
			
		case 3:
			Debug.Log("method is being collaced pulse");
			if (Input.GetKey(KeyCode.S))
			{ 			_language.colorJump3();
				match.Play();
			}
			 else if(Input.GetKey(KeyCode.A))
			{damage.Play();
				wrongChoice(1);
			}
			 else if (Input.GetKey(KeyCode.W))
			{damage.Play();
				wrongChoice(1);
			}
				break;		
			
		}
		
	}
			          void pinkHype(){

				// method will color change from default color to desired color 
				//also make particle effect and a new sound which will signal correct gate
			}
			void yellowHype(){
				
				
			}
			void greenHype(){
				
				
			}

	void wrongChoice(int incre){
		incre += 1;
		if (incre <= 1) {
			StartCoroutine (wrongCo ());
		} else if(incre > 1) {
			StartCoroutine (wrongCo_2 ());
		}
	}
			
	
	
	 IEnumerator wrongCo() 
	{
		Color currentColor = cam.backgroundColor;
		
		
		
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) {
			
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[3], time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
			
		}
		

	}

	 IEnumerator wrongCo_2 () 
	{
		Color currentColor = cam.backgroundColor;
		
		
		
		
		float time = .25f;
		float logic = gradate / duration;
		while (time < 1) {
			
			cam.backgroundColor = Color.LerpUnclamped (currentColor, colors[4], time);
			time += logic;
			yield return new WaitForSeconds (gradate);
			
			
		}
		
		
		
		
		
	}
	
	
	
	
	
}
