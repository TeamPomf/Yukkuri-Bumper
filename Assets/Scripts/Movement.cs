using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Rigidbody myRigidBody;

// Use this for initialization
    void Start ()
    {
        myRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    void Move()
    {
        if (Input.GetKey("up"))
        {
            myRigidBody.AddForce(Vector3.forward * Time.deltaTime*100);
        };
        if (Input.GetKey("down"))
        {
            myRigidBody.AddForce(Vector3.back * Time.deltaTime*100);
        };
        if (Input.GetKey("left"))
        {
            myRigidBody.AddForce(Vector3.left * Time.deltaTime * 100);
        };
        if (Input.GetKey("right"))
        {
            myRigidBody.AddForce(Vector3.right * Time.deltaTime * 100);
        };
    }
}
