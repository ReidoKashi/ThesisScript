using UnityEngine;
using System.Collections;

public class healthBarSystem : MonoBehaviour {
	public GameObject health_1;
	public GameObject health_2;
	public GameObject health_3;
	public CrashAmount _healthIncrement;





	public void showHealth()
	{
		StartCoroutine (healthShow ());


	}
	 IEnumerator healthShow()
	{
		if (_healthIncrement.gameOver == 1) {
			health_1.SetActive(false);
			health_2.SetActive(true);
			health_3.SetActive(false);
		} else if (_healthIncrement.gameOver == 2) {
			health_1.SetActive(false);
			health_2.SetActive(false);
			health_3.SetActive(true);
		} 
		yield return new WaitForSeconds(1f);
		health_1.SetActive(false);
		health_2.SetActive(false);
		health_1.SetActive(false);
	}


}
