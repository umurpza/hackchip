using UnityEngine;
using System.Collections;

public class FinishScript : MonoBehaviour {

	public GameObject powahSwitch;
	public PointsCounter pointsCounter;
	public int points;

	public void OnTriggerEnter2D(Collider2D collider) {
		if (collider.CompareTag("Bug")) {

			if (collider.gameObject.name.Equals("redbug2")) {
				powahSwitch.GetComponent<Powah>().StartBug3();
			}
			else
			{
				powahSwitch.transform.Rotate(Vector3.forward * 180);
			}

			pointsCounter.UpdatePoints(points);
			Destroy (collider.gameObject);
		}
	}

}