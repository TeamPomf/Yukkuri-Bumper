using UnityEngine;
using System.Collections;

public class Conveyor : MonoBehaviour {
   public float rotationSpeed = 1000;
    
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed);
	}

   
}
