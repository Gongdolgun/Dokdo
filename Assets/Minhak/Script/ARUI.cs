using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARUI : MonoBehaviour
{
    bool onRenderer = false;
    bool OldRenderer = true;
    public GameObject ar;
    public GameObject NextUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //랜더러를 기준으로 상태가 변하고 켜지면 리셋 시행함, 리셋이 아주중요
        Renderer r = GetComponent<Renderer>();
        onRenderer = r.enabled;
        if (OldRenderer != onRenderer)
        {
            if (onRenderer == true) //트래킹 시작
            {
                ar.SetActive(false);
                NextUI.SetActive(true);

            }
            else //트래킹 사라짐
            {
                
                ar.SetActive(true);
                NextUI.SetActive(false);

                
            }
        }
        OldRenderer = onRenderer;
    }
}
