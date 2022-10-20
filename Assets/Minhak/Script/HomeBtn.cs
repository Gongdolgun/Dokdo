using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBtn : MonoBehaviour
{
    public GameObject[] UI;
    public GameObject StartUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isclicked()
    {
        foreach(GameObject g in UI)
        {
            g.SetActive(false);
        }

        StartUI.SetActive(true);
    }
}
