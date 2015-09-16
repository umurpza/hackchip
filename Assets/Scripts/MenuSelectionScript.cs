using UnityEngine;
using System.Collections;

public class MenuSelectionScript : MonoBehaviour {
	public GameObject bug;

	void OnMouseOver() {
		bug.SetActive(true);
	}

	void OnMouseExit() {
		bug.SetActive(false);
	}

	void OnMouseDown() {
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

			if (hit.collider != null) {
				switch (hit.collider.gameObject.tag) {
					case "Play":
						Debug.Log("Play Entered");
						Application.LoadLevel("Main");
						break;
					case "Exit":
						Debug.Log("Exit Entered");
						Application.Quit();
						break;
				}
			}
		}
	}

}
