using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Quaternion : MonoBehaviour {
	Quaternion fixedAngle;
	float angle = 10;
	// Use this for initialization
	void Start () {
		fixedAngle = transform.rotation;
	}
	// Update is called once per frame
	void Update () {
		Quaternion rot1 = Quaternion.AngleAxis (angle, Vector3.right);
		Quaternion rot2 = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation *= rot1 * rot2; 
	}
}
