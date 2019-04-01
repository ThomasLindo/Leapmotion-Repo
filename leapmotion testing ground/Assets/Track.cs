using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{

    public GameObject Tracking;
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = Tracking.GetComponent<Transform>().position;
       
    }
}
