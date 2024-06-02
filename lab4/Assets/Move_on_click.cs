using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move_on_click : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData eventData) {
		int forse = 1000;
		Vector3 target = eventData.pointerPressRaycast.worldPosition;
		Vector3 collid = Camera.main.transform.position; 
		Vector3 distance = target - collid;
		distance = distance.normalized;
		collid = distance * forse;
		gameObject.GetComponent<Rigidbody>().AddForceAtPosition (collid, target);
	}
}
