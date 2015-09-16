using UnityEngine;
using System.Collections;

public class colSEC4Script : MonoBehaviour
{
    public GameObject terminalObj;
    public TerminalSprites ts;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //terminalObj = Instantiate(Resources.Load("terminalRomSpriteSheet_Flat_1")) as GameObject;
            SpriteRenderer renderer = terminalObj.GetComponent<SpriteRenderer>();
            Sprite sprite = ts.sprites[14];
            renderer.sprite = sprite;
            terminalObj.transform.GetChild(12).gameObject.SetActive(false);
            terminalObj.transform.GetChild(13).gameObject.SetActive(true);
            Debug.Log("ClickedSEC4");
        }
    }
}