using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink_DS_2 : MonoBehaviour
{
    bool onRenderer = false;
    bool OldRenderer = true;
    public GameObject SeaAnimal_btn;
    public GameObject Animal_btn;
    public GameObject Plants_btn;
    // Start is called before the first frame update
    void Update()
    {
        //랜더러를 기준으로 상태가 변하고 켜지면 리셋 시행함, 리셋이 아주중요
        Renderer r = GetComponent<Renderer>();
        onRenderer = r.enabled;
        if (OldRenderer != onRenderer)
        {
            if (onRenderer == true) //트래킹 시작
            {
                Blink SeaAnimalblink = SeaAnimal_btn.GetComponent<Blink>();
                Blink Animalblink = Animal_btn.GetComponent<Blink>();
                Blink Plantsblink = Plants_btn.GetComponent<Blink>();

                SeaAnimalblink.destroy = false;
                Animalblink.destroy = false;
                Plantsblink.destroy = false;

            }
            else //트래킹 사라짐
            {
               
            }
        }
        OldRenderer = onRenderer;
    }
}
