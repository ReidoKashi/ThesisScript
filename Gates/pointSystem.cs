using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pointSystem : MonoBehaviour {

	int _points = 0;
	public Text pointsToSystem; // assign in Inspector
	
	// a function must be "public void" in order for UI to call it
	public void EarnAPoint () {
		_points++; // add 1 to existing value
		pointsToSystem.text = "GAME SCORE " + _points.ToString();
	}

	public void earnFive () {
		_points += 5; // add 1 to existing value
		pointsToSystem.text = "GAME SCORE " + _points.ToString();
	}

}
// Code source originally taken from Robert Yangs Building World: Day 3 class UI Design