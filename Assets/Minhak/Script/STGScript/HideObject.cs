using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    public GameObject[] STGObject;
    bool onRenderer = false;
    bool OldRenderer = true;
    public GameObject[] Labels;

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
                foreach (GameObject g in Labels)
                {
                    g.SetActive(true);
                }
            }
            else //트래킹 사라짐
            {
                foreach (GameObject g in STGObject)
                {
                    g.SetActive(false);
                }

                foreach (GameObject g in Labels)
                {
                    g.transform.position = new Vector3(30000, 0, 0);
                    g.SetActive(false);
                }
            }
        }
        OldRenderer = onRenderer;
    }
}
