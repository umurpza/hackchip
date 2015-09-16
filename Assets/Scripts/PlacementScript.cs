using UnityEngine;
using System.Collections;

public class PlacementScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		transform.position = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float posZ = transform.position.z - Camera.main.transform.position.z;
		Vector3 newPosition = new Vector3(
			position.x,
			position.y,
			0.0f);

		transform.position = newPosition;
	}

}
