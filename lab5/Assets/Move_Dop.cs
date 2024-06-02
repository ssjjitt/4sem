using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Dop : MonoBehaviour {
    public float speed = 5f;
    void Start () {
		
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        else if (Input.GetKey(KeyCode.H))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
