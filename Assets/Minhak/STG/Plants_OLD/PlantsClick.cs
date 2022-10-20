using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsClick : MonoBehaviour
{
    public GameObject PlantsPin;
    private Animation anim;
    public GameObject[] HideObj;
    public GameObject[] ShowObj;


    private void Start()
    {
        anim = PlantsPin.GetComponent<Animation>();
    }

    public void btnClick()
    {
        Blink SeaAnimalblink = GameObject.Find("SeaAnimal_btn").GetComponent<Blink>();
        Blink Animalblink = GameObject.Find("Animal_btn").GetComponent<Blink>();
        Blink Plantsblink = GameObject.Find("Plants_btn").GetComponent<Blink>();

        SeaAnimalblink.destroy = true;
        Animalblink.destroy = true;
        Plantsblink.destroy = true;

        PlantsPin.SetActive(true);
        anim.Play("PlantsAnim");
        foreach (GameObject g in HideObj)
        {
            g.SetActive(false);
        }
        foreach (GameObject g in ShowObj)
        {
            g.SetActive(true);
        }
        


    }
}
