using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        float b = Input.GetAxis("Mouse X");
        float c = Input.GetAxis("Horizontal");
        float d = Input.GetAxis("Vertical");
        transform.Translate(c, 0, d);
        transform.Rotate(0, b, 0);
        Mathf.Clamp(0, 0, 20);
    }
}
