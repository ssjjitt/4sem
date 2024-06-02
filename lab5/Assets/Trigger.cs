using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	[SerializeField]
	public Light Point;

    public void OnTriggerEnter(Collider col)
	{
		if(col.name == "player")
		{
			Point.enabled = true;
		}
	}

    public void OnTriggerExit(Collider col)
    {
        if (col.name == "player")
        {
            Point.enabled = false; 
        }
    }
}
