using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Powah : MonoBehaviour {

	public GameObject bug1;
	public GameObject bug2;
	public GameObject bug3;
	//	public TargetWalker targetWalkerScript;
	private bool firstRun = true;

	void OnMouseDown() {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
			
			if (hit.collider != null) {
				AudioSource click = gameObject.GetComponent<AudioSource>();
				click.Play();

				transform.Rotate(Vector3.forward * 180);

				StartBugs();
			}
		}
	}

	private void StartBugs() {
		if (firstRun)
		{
			TargetWalker script = bug1.GetComponent<TargetWalker>();
			script.Run();
			firstRun = false;
		}
		else
		{
			TargetWalker script = bug2.GetComponent<TargetWalker>();
			script.Run();
		}
	}

	public void StartBug3() {
		TargetWalker script = bug3.GetComponent<TargetWalker>();
		script.Run();
	}

}
