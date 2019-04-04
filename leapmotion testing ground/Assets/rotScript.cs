using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool spin = true;
  

    // Update is called once per frame
    void Update()
    {
        if (spin)
        {
            this.transform.Rotate(0, 0.5f, 0, Space.Self);
        }
        else
        {
            this.transform.Rotate(0, -0.5f, 0, Space.Self);
        }
    }

    public void ToggleSpin()
    {
        spin = !spin;
    }
}
