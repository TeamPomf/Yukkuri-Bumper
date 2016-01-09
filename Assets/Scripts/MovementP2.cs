using UnityEngine;
using System.Collections;

public class MovementP2 : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}
    void Move()
    {
        if (Input.GetKey("up"))
        {
            rb.AddForce(Vector3.forward * Time.deltaTime * 200);
        };
        if (Input.GetKey("down"))
        {
            rb.AddForce(Vector3.back * Time.deltaTime * 200);
        };
        if (Input.GetKey("left"))
        {
            rb.AddForce(Vector3.left * Time.deltaTime * 200);
        };
        if (Input.GetKey("right"))
        {
            rb.AddForce(Vector3.right * Time.deltaTime * 200);
        };
    }
}
