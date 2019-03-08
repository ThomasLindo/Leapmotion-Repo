using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject PalmTracker;

    public void ClickFunction()
    {
        if (PalmTracker.GetComponent<ClickScript>().LClick)
        {
            Debug.Log("BUTTON CLICK L!!!!!");
        }else if (PalmTracker.GetComponent<ClickScript>().RClick)
        {
            Debug.Log("BUTTON CLICK R!!!!!");
        }
    }
}
