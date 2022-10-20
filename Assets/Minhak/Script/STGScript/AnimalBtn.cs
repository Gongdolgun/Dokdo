using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBtn : MonoBehaviour
{
    public GameObject AnimalPin;
    private Animation anim;
    public GameObject[] HideObj;
    public GameObject[] ShowObj;


    private void Start()
    {
        anim = AnimalPin.GetComponent <Animation> ();
    }

    public void btnClick() 
    {
        Blink SeaAnimalblink = GameObject.Find("SeaAnimal_btn").GetComponent<Blink>();
        Blink Animalblink = GameObject.Find("Animal_btn").GetComponent<Blink>();
        Blink Plantsblink = GameObject.Find("Plants_btn").GetComponent<Blink>();

        SeaAnimalblink.destroy = true;
        Animalblink.destroy = true;
        Plantsblink.destroy = true;

        AnimalPin.SetActive(true);
        anim.Play("AnimalAnim");
        foreach(GameObject g in HideObj)
        {
            g.SetActive(false);
        }
        foreach(GameObject g in ShowObj)
        {
            g.SetActive(true);
        }
        

    }
}
