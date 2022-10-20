using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelSet : MonoBehaviour
{
    public GameObject[] LabelUI;
    public GameObject Pin;

    // Start is called before the first frame update
    public void setPosition()
    {

        foreach (GameObject g in LabelUI)
        {
            g.transform.position = new Vector3(30000, 0, 0);
        }
        Pin.SetActive(false);
        Invoke("ShowPin", 0.1f);
    }

    public void ShowPin()
    {
        Pin.SetActive(true);
    }
}
