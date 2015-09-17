using UnityEngine;
using System.Collections;

public class SecChipSelectScript : MonoBehaviour {

	public PointsCounter pointsCounter;
	public GameObject secChip;

	void OnMouseDown() {
		Debug.Log("Click");
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

			if (hit.collider != null) {
				Debug.Log ("Click");
				secChip.SetActive(true);
				pointsCounter.UpdatePoints(-50);
			}
		}
	}

}
