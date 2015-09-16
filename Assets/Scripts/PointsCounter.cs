using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour {

	public Text scoreText;
	public int score;

	// Use this for initialization
	void Start () {
		scoreText.text = score + " KB";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdatePoints(int points) {
		if (score == 0) return;

		score += points;

		if (score < 0) score = 0;

		scoreText.text = score + " KB";
	}
}
