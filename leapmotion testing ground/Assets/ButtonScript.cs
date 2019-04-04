using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    public GameObject PalmTracker;
    public GameObject Image;
    public int butNum;
    public void ClickFunction()
    {
        if (PalmTracker.GetComponent<ClickScript>().LClick)
        {
            if (butNum == 1)
            {
                Image.GetComponent<imageScript>().SetImage(1);
            }
            else if (butNum == 2)
            {
                Image.GetComponent<imageScript>().SetImage(3);
            }
            else if (butNum == 3)
            {
                Image.GetComponent<imageScript>().SetImage(5);
            }
            else if (butNum == 4)
            {
                Image.GetComponent<imageScript>().SetImage(7);
            }
            else if (butNum == 5)
            {
                Image.GetComponent<imageScript>().SetImage(9);
            }

                Debug.Log("BUTTON CLICK L!!!!!");
        }else if (PalmTracker.GetComponent<ClickScript>().RClick)
        {
            if (butNum == 1)
            {
                Image.GetComponent<imageScript>().SetImage(2);
            }
            else if (butNum == 2)
            {
                Image.GetComponent<imageScript>().SetImage(4);
            }
            else if (butNum == 3)
            {
                Image.GetComponent<imageScript>().SetImage(6);
            }
            else if (butNum == 4)
            {
                Image.GetComponent<imageScript>().SetImage(8);
            }
            else if (butNum == 5)
            {
                Image.GetComponent<imageScript>().SetImage(10);
            }
            Debug.Log("BUTTON CLICK R!!!!!");
        }
    }
}
