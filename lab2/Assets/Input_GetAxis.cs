using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_GetAxis : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float a = Input.GetAxis("Mouse Y");
		float b = Input.GetAxis("Mouse X"); 
		float c = Input.GetAxis("Horizontal");
		float d = Input.GetAxis("Vertical");
		transform.Translate(c, 0, d);
		transform.Rotate(a, b, 0);
		Mathf.Clamp(a, 0, 90);
	}
}
