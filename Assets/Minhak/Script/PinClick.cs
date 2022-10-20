using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PinClick : MonoBehaviour
{
    public GameObject DDUI;
    public GameObject[] PinGroup;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        foreach (GameObject g in PinGroup)
        {
            g.GetComponent<Collider>().enabled = false;

            Debug.Log(g.GetComponent<Collider>());
            
        }
        DDUI.SetActive(true);
        
    }
}
