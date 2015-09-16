﻿using UnityEngine;
using System.Collections;

public class colROM7Script : MonoBehaviour
{
    public GameObject terminalObj;
    public TerminalSprites ts;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //terminalObj = Instantiate(Resources.Load("terminalRomSpriteSheet_Flat_1")) as GameObject;
            SpriteRenderer renderer = terminalObj.GetComponent<SpriteRenderer>();
            Sprite sprite = ts.sprites[8];
            renderer.sprite = sprite;
            terminalObj.transform.GetChild(6).gameObject.SetActive(false);
            terminalObj.transform.GetChild(7).gameObject.SetActive(true);
            Debug.Log("Clicked7");
        }
    }
}