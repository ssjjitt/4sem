using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snaryad : MonoBehaviour {

	public int coreSpeed = 5;
    public GameObject exp1;
    void Start () {
		
	}
	
	void Update () {
        transform.position += transform.TransformDirection(Vector3.right * coreSpeed);
    }

	public void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "allo")
		{
			GetComponent<Renderer>().enabled = false;
            Instantiate(exp1, gameObject.transform);
            col.gameObject.GetComponent<AudioSource>().PlayOneShot(col.gameObject.GetComponent<AudioSource>().clip);
        }
    }
}
