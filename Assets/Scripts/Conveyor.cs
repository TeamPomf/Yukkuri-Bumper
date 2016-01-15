using UnityEngine;
using System.Collections;

public class Conveyor : MonoBehaviour {
    public float rotationSpeed = 1000;
  

    public GameObject[] wheels;
    Rigidbody rb;
    
    
    
    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
       rb.AddForce(transform.right*100);
    }


    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        foreach (var wheel in wheels)
        {
            wheel.transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
        }
       
    }

   
}
