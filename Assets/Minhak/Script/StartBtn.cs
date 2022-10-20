using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public GameObject HideUI;
    public GameObject ShowUI;
/*    public Color wantedColor;
    public Button btn;
    public Button[] UnclickedBtn;
*/
    //public bool isclicked = false;

    public void btnClicked()
    {
        HideUI.SetActive(false);
        ShowUI.SetActive(true);
    }

    /*public void ChangeColor()
    {
        ColorBlock cb = btn.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        cb.selectedColor = wantedColor;
        cb.disabledColor = wantedColor;
        btn.colors = cb;

    }*/
}
