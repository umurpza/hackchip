using UnityEngine;
using System.Collections;

public class colROM9Script : MonoBehaviour
{
    public GameObject terminalObj;
    public TerminalSprites ts;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //terminalObj = Instantiate(Resources.Load("terminalRomSpriteSheet_Flat_1")) as GameObject;
            SpriteRenderer renderer = terminalObj.GetComponent<SpriteRenderer>();
            Sprite sprite = ts.sprites[0];
            renderer.sprite = sprite;
            terminalObj.transform.GetChild(8).gameObject.SetActive(false);
            Debug.Log("Clicked9");
        }
    }
}
