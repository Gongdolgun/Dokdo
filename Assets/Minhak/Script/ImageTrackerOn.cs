using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTrackerOn : MonoBehaviour
{
    public GameObject[] ImageTracker;
    // Start is called before the first frame update
    
    public void TrackerOn()
    {
        foreach(GameObject g in ImageTracker)
        {
            g.SetActive(true);
        }
    }

    public void TrackerOff()
    {
        foreach(GameObject g in ImageTracker)
        {
            g.SetActive(false);
        }
    }
}
