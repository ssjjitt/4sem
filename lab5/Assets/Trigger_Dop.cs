using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Dop : MonoBehaviour {
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;

    public void OnTriggerEnter(Collider col) 
    { 
        if (col.name == "player") 
        {
            Cube1.transform.position -= new Vector3(1f, 0, 0);
            Cube2.transform.position += new Vector3(1f, 0, 0);
        }
    }
    public void OnTriggerExit(Collider col) 
    { 
        if (col.name == "player") 
        {
            Cube1.transform.position += new Vector3(1f, 0, 0);
            Cube2.transform.position -= new Vector3(1f, 0, 0);       
        } 
    }
    public void OnTriggerStay(Collider col)
    {
        if (col.name == "robot")
        { 
            Cube3.transform.Translate(0, 0, 0.01f); 
            Cube3.transform.Rotate(1, 0, 0); 
        }
    }

}
