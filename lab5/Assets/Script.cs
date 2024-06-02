using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
	void Start () {
		
	}
	
	void Update () {
		float a = Input.GetAxis("Mouse Y");
		float b = Input.GetAxis("Mouse X"); 
		float c = Input.GetAxis("Horizontal");
		float d = Input.GetAxis("Vertical");
		transform.Translate(c, 0, d);
		transform.Rotate(a, b, 0);
		Mathf.Clamp(a, 0, 20);
}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Cube1")
		{ 
			col.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0); 
		}
		if (col.gameObject.name == "Cube2")
		{
			col.gameObject.GetComponent<Renderer>().material.mainTexture = Resources.Load("pic") as Texture; 
		}
	}


}
