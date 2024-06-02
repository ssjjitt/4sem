using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Script : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData eventData) {
		float red = Random.Range(.0f, 1.0f); 
		float green = Random.Range(.0f, 1.0f); 
		float blue = Random.Range(.0f, 1.0f); 
		Color col1 = new Color (red, green, blue);
		gameObject.GetComponent<Renderer>().material.color = col1; 
	}
}
