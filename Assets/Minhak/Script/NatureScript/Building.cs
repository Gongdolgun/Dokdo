using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject BuildingPin;
    private Animation anim;
    public GameObject[] HideObj;
    public GameObject[] ShowObj;
    

    private void Start()
    {
        anim = BuildingPin.GetComponent<Animation>();
        
    }

    public void btnClick()
    {
        foreach (GameObject g in ShowObj)
        {
            g.SetActive(true);
        }

        anim.Play("BuildingAnim");
        foreach (GameObject g in HideObj)
        {
            g.SetActive(false);
        }

        Blink Buildingblink = GameObject.Find("Building").GetComponent<Blink>();
        Blink Natureblink = GameObject.Find("Nature").GetComponent<Blink>();
        Buildingblink.destroy = true;
        Natureblink.destroy = true;
    }
}
