using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_trigg : MonoBehaviour {

    public Light point2;
    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "tank_3ds")
        {
            if (point2.intensity < 30)
                point2.intensity += 5;
            else point2.intensity = 0;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.name == "tank_3ds")
        {
            point2.intensity = 0;
        }
    }
}
