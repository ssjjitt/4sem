using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Euler : MonoBehaviour {

	private float previousRotationX = 10; 
	private float previousRotationZ = 10;  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float currentRotationX = transform.rotation.eulerAngles.x;
		float currentRotationZ = transform.rotation.eulerAngles.z;

		float rotationChangeX = currentRotationX - previousRotationX;
		float rotationChangeZ = currentRotationZ - previousRotationZ;

		transform.Rotate(new Vector3(rotationChangeX, 0f, rotationChangeZ));

		previousRotationX = currentRotationX;
		previousRotationZ = currentRotationZ;
	}
}
