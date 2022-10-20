using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public float time;
    public GameObject me;
    public bool destroy = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroy == false) {
            time = time + Time.deltaTime;

            if (time < 0.5)
            {
                me.SetActive(true);
            }

            else if (0.5 < time && time < 1)
            {
                me.SetActive(false);
            }

            else if (1 < time)
                time = 0;
        }

        else if (destroy == true)
        {
            me.SetActive(false);
        }
    }
}
