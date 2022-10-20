using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STGClick : MonoBehaviour
{
    public GameObject SeaAnimalPin;
    private Animation anim;
    public GameObject[] HideObj;
    public GameObject[] ShowObj;


    private void Start()
    {
        anim = SeaAnimalPin.GetComponent<Animation>();
    }

    public void btnClick()
    {
        Blink SeaAnimalblink = GameObject.Find("SeaAnimal_btn").GetComponent<Blink>();
        Blink Animalblink = GameObject.Find("Animal_btn").GetComponent<Blink>();
        Blink Plantsblink = GameObject.Find("Plants_btn").GetComponent<Blink>();

        SeaAnimalblink.destroy = true;
        Animalblink.destroy = true;
        Plantsblink.destroy = true;

        SeaAnimalPin.SetActive(true);
        anim.Play("SeaanimalAnim");
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
