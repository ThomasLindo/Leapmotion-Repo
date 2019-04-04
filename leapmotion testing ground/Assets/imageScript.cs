using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class imageScript : MonoBehaviour
{
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;
    public Sprite sp4;
    public Sprite sp5;
    public Sprite sp6;
    public Sprite sp7;
    public Sprite sp8;
    public Sprite sp9;
    public Sprite sp10;
    // Update is called once per frame
    public void SetImage(int image)
    {
        if (image == 1)
        {
            this.GetComponent<Image>().sprite = sp1;
        }
        else if (image == 2)
        {
            this.GetComponent<Image>().sprite = sp2;
        }
        else if (image == 3)
        {
            this.GetComponent<Image>().sprite = sp3;
        }
        else if (image == 4)
        {
            this.GetComponent<Image>().sprite = sp4;
        }
        else if (image == 5)
        {
            this.GetComponent<Image>().sprite = sp5;
        }
        else if (image == 6)
        {
            this.GetComponent<Image>().sprite = sp6;
        }
        else if (image == 7)
        {
            this.GetComponent<Image>().sprite = sp7;
        }
        else if (image == 8)
        {
            this.GetComponent<Image>().sprite = sp8;
        }
        else if (image == 9)
        {
            this.GetComponent<Image>().sprite = sp9;
        }
        else if (image == 10)
        {
            this.GetComponent<Image>().sprite = sp10;
        }
    }
    
}
