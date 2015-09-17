using UnityEngine;
using System.Collections;

public class TerminalAnimation : MonoBehaviour {
	public GameObject terminalObj;
	public GameObject nextObject;
	public GameObject route1;
	public GameObject route2;
	public Sprite sprite;
	public bool hide = true;
	public bool showRoutes;
	public bool hideRoutes;
	
	void OnMouseDown()
	{
		if (Input.GetMouseButtonDown(0))
		{
			SpriteRenderer renderer = terminalObj.GetComponent<SpriteRenderer>();
			renderer.sprite = sprite;

			if (hide)
				this.gameObject.SetActive(false);

			if (nextObject != null)
				nextObject.SetActive(true);

			if (showRoutes) {
				route1.SetActive(true);
				route2.SetActive(true);
			}

			if (hideRoutes) {
				route1.SetActive(false);
				route2.SetActive(false);
			}
		}
	}
}
