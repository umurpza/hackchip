using UnityEngine;
using System.Collections;

public class TerminalAnimation2 : MonoBehaviour {
    public GameObject go;

    public GameObject terminalObj;
    public TerminalSprites ts;

	// Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //terminalObj = Instantiate(Resources.Load("terminalRomSpriteSheet_Flat_1")) as GameObject;
            SpriteRenderer renderer = terminalObj.GetComponent<SpriteRenderer>();
            Sprite sprite = ts.sprites[10];
            renderer.sprite = sprite;
            terminalObj.transform.GetChild(9).gameObject.SetActive(true);
        }
	}
}
