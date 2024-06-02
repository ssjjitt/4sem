using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour {

	// префаб
	public GameObject prefub1;
	// каркас
	MeshRenderer rend;
	// плоскость
	public float minX;
	public float minZ;
	public float maxX;
	public float maxZ;
	// объект
	public float nX;
	public float nY;
	public float nZ;
	// Use this for initialization
	void Start () {
		rend = GetComponent<MeshRenderer>();
		minX = rend.bounds.min.x;
		maxX = rend.bounds.max.x;
		minZ = rend.bounds.min.z;
		maxZ = rend.bounds.max.z;
		nY = gameObject.transform.position.y + 5;

	}

	// Update is called once per frame
	void Update () {

		nX = Random.Range (minX, maxX);
		nZ = Random.Range (minZ, maxZ);
		if (Input.GetKeyDown (KeyCode.Q)) {
			GameObject cub = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cub.transform.position = new Vector3 (nX, nY, nZ);
			cub.AddComponent<Rigidbody> ();
		}
		if(Input.GetKeyDown(KeyCode.W)){
			Quaternion rotZ = Quaternion.AngleAxis (-1, new Vector3 (0, 0, 1));
			gameObject.transform.rotation *= rotZ;
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			Vector3 position = new Vector3 (nX, nY, nZ);
			Instantiate (prefub1,position,Quaternion.identity);
		}
	}
}
