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
        
        if (collision.gameObject.tag == "Thumb")
        {
            if (!RClickState)
            {
                RClick = true;
               
            }
            else
            {
                LClick = true;
                
            }
        }
        if (collision.gameObject.tag == "MiddleF")
        {
            RClickState = true;
          
        }
       
    }
    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "Thumb")
        {
            RClick = false;
            LClick = false;
           
        }

        if (collision.gameObject.tag == "MiddleF")
        {
            RClickState = false;
           
        }

    }
}
