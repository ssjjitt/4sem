using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class blue_trigg : MonoBehaviour {
    public Light point1;
    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "tank_3ds")
        {
            if (point1.intensity < 30)
                point1.intensity += 5;
            else point1.intensity = 0;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.name == "tank_3ds")
        {
            point1.intensity = 0;
        }
    }
}
