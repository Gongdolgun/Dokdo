using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xbtn : MonoBehaviour
{
    public GameObject ThisUI;
    public GameObject[] Pins;

    public void UIExit()
    {
        ThisUI.SetActive(false);
    }

    public void Pin()
    {
        foreach (GameObject g in Pins)
        {
            g.GetComponent<Collider>().enabled = true;
        }
    }
}
