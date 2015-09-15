using UnityEngine;
using System.Collections;

public class PlacementScript : MonoBehaviour {

	private Collider2D pinPointCollider = null;
	private bool isPinned = false;

	// Use this for initialization
	void Start () {
		transform.position = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (isPinned)
			return;

		if (pinPointCollider != null && Input.GetMouseButtonDown(0)) {
			Vector3 offset = (pinPointCollider as CircleCollider2D).offset;
			transform.position = offset + pinPointCollider.gameObject.transform.position;
			isPinned = true;
			return;
		}

		Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float posZ = transform.position.z - Camera.main.transform.position.z;
		Vector3 newPosition = new Vector3(
			position.x,
			position.y,
			0.0f);
/*		Vector3 newPosition = new Vector3(
			Mathf.Floor(position.x),
			Mathf.Floor(position.y),
			0.0f);
*/		transform.position = newPosition;
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.CompareTag("Pin")) {
			collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
			pinPointCollider = collider;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		collider.gameObject.transform.GetChild(0).gameObject.SetActive(false);
		pinPointCollider = null;
	}
}
