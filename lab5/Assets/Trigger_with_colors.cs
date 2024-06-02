using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_with_colors : MonoBehaviour {

    public GameObject Cylinder; public Light Point1; public Light Point2; public Light Point3; void OnTriggerStay(Collider col)
    {
        if (col.name == "player")
        { 
            Cylinder.transform.Rotate(0, 0.1f, 0); 
            if (Point1.intensity < 10) 
                Point1.intensity += 0.01f; 
            else Point1.intensity = 0; 

            if (Point2.intensity < 10) 
                Point2.intensity += 0.01f; 
            else Point2.intensity = 0; 
            
            if (Point3.intensity < 10) 
                Point3.intensity += 0.01f; 
            else Point3.intensity = 0; 
        }
    }
}
