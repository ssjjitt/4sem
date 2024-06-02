using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_1 : MonoBehaviour {

    public GameObject box;

    public void OnTriggerStay(Collider col)
    {
        if (col.name == "tank_3ds")
        {
            box.transform.Rotate(0, 0, 2);
        }
    }
}
