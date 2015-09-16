using UnityEngine;
using System.Collections;

public class colROM6Script : MonoBehaviour
{
    public GameObject terminalObj;
    public TerminalSprites ts;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //terminalObj = Instantiate(Resources.Load("terminalRomSpriteSheet_Flat_1")) as GameObject;
            SpriteRenderer renderer = terminalObj.GetComponent<SpriteRenderer>();
            Sprite sprite = ts.sprites[7];
            renderer.sprite = sprite;
            terminalObj.transform.GetChild(5).gameObject.SetActive(false);
            terminalObj.transform.GetChild(6).gameObject.SetActive(true);
            Debug.Log("Clicked6");
        }
    }
}