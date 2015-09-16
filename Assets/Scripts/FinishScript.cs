using UnityEngine;
using System.Collections;

public class FinishScript : MonoBehaviour {

	public GameObject bug;
	public PointsCounter pointsCounter;

	public void OnTriggerEnter2D(Collider2D collider) {
		if (collider.CompareTag("Bug"))
			pointsCounter.UpdatePoints(10);
	}

}