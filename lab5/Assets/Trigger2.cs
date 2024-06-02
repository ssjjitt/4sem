using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour {

    [SerializeField]
    public Light Spot;
    public float rotationSpeed = 0.1f;
    public float radius = 0.4f;
    private float angle = 0f;
    public void OnTriggerStay(Collider col)
    {
        if (col.name == "player")
        {
            float y = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Spot.transform.position = new Vector3(Spot.transform.position.y, y, z);
            angle += rotationSpeed * Time.deltaTime;
            if (angle >= 360f)
            {
                angle -= 360f;
            }
        }
    }
}
