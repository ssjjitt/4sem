using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour {

    Transform bash;			
	Transform stv; 			
	float TankMoveSpeed = 0.5f; 
	float RotateSpeed = 0.5f; 	 
	float min = 0f;			
	float max = 5f;
    AudioSource zvtank;
    bool isPlaying = false;
    // бомбы
    MeshRenderer rend;
    public float minX;
    public float minZ;
    public float maxX;
    public float maxZ;
    public float nX;
    public float nY;
    public float nZ;
    
    void Start () {
        bash = gameObject.transform.Find("bashnya");
        stv = bash.transform.Find("stvol");
        rend = GetComponent<MeshRenderer>();
        minX = rend.bounds.min.x;
        maxX = rend.bounds.max.x;
        minZ = rend.bounds.min.z;
        maxZ = rend.bounds.max.z;
        nY = gameObject.transform.position.y + 20;
        zvtank = GetComponent<AudioSource>();
    }

    void Update () {
        float z = Input.GetAxis("Vertical");         
        transform.Translate(z * TankMoveSpeed, 0, 0);                       

        float x = Input.GetAxis("Horizontal");      
        transform.Rotate(0f, x * TankMoveSpeed, 0f);

        float h = Input.GetAxis("Mouse X");
        bash.Rotate(0f, h * RotateSpeed, 0f);      

        float v = Input.GetAxis("Mouse Y");
         
        stv.transform.Rotate(0f, 0f, v * RotateSpeed);
        float new_angle = Mathf.Clamp(stv.transform.localEulerAngles.z, min, max);
        stv.localEulerAngles = new Vector3(0f, 0f, new_angle);

        // опять бомбы
        nX = Random.Range(minX, maxX);
        nZ = Random.Range(minZ, maxZ);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject cub = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            cub.transform.position = new Vector3(nX, nY, nZ);
            cub.AddComponent<Rigidbody>();
        }

        // звуки
        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && !isPlaying)
        { 
            zvtank.Play(); isPlaying = true; 
        }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && isPlaying)
        { 
            zvtank.Stop(); isPlaying = false; 
        }
    }
}
