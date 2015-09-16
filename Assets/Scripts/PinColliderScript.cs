using UnityEngine;
using System.Collections;

public class PinColliderScript : MonoBehaviour {

	private Collider2D pinPointCollider = null;
	private bool isPinned = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isPinned)
			return;
		
		if (pinPointCollider != null && Input.GetMouseButtonDown(0)) {
			Vector3 pinOffset = transform.parent.position - transform.position;

			Vector3 offset = (pinPointCollider as CircleCollider2D).offset;
//			transform.position = offset + pinPointCollider.gameObject.transform.position;

			transform.parent.gameObject.GetComponent<PlacementScript>().enabled = false;

			Vector3 v1 = offset + pinPointCollider.gameObject.transform.position;
			Vector3 v2 = v1 + pinOffset;

			transform.parent.position = v2;

			isPinned = true;
			return;
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log(collider.gameObject.transform.childCount);
		if (collider.gameObject.tag == "OpenPin") {
			Transform parent = collider.gameObject.transform;
			foreach (Transform child in parent) {
				Debug.Log(child.name);
				child.gameObject.SetActive(true);
			}
			pinPointCollider = collider;
		}
	}
	
	void OnTriggerExit2D(Collider2D collider) {
		if (pinPointCollider == null)
			return;

		if (collider.gameObject.transform.childCount > 0) {
			foreach (Transform child in collider.gameObject.transform) {
				child.gameObject.SetActive(false);
			}
		}
		
		pinPointCollider = null;
	}
}
