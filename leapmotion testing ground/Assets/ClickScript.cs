using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ClickScript : MonoBehaviour
{
    public bool LClick = false;

    public bool RClick = false;

    public bool RClickState = false;
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("pootis");
        if (collision.gameObject.tag == "Thumb")
        {
            if (!RClickState)
            {
                RClick = true;
                Debug.Log("Right Clcik");
            }
            else
            {
                LClick = true;
                Debug.Log("Left Clcik");
            }
        }
        if (collision.gameObject.tag == "MiddleF")
        {
            RClickState = true;
            Debug.Log("left click mode on!");
        }
       
    }
    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "Thumb")
        {
            RClick = false;
            LClick = false;
            Debug.Log("no longer clicking");
        }

        if (collision.gameObject.tag == "MiddleF")
        {
            RClickState = false;
            Debug.Log("right click mode on!");
        }

    }
}
