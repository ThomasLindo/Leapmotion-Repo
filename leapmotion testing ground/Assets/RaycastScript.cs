using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RaycastScript : MonoBehaviour
{
    public GameObject PalmTracker;


    private void Update()
    {
        RaycastHit hit;
        Ray raycast = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(raycast, out hit, 100000000.0f))
        {
            if (hit.transform != null)
            {
                if (hit.transform.tag == "Button")
                {
                    Debug.Log("that's a button");
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                }
            }
        }
    }
}
