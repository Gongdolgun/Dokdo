using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinAnimPlay : MonoBehaviour
{
    private Animation anim;
    bool onRenderer = false;
    bool OldRenderer = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Renderer r = GetComponent<Renderer>();
        onRenderer = r.enabled;
        if (OldRenderer != onRenderer)
        {
            if (onRenderer == true) //트래킹 시작
            {
                anim.Play("PinAnim");
            }
            else //트래킹 사라짐
            {
                
            }
        }
        OldRenderer = onRenderer;
    }
}
