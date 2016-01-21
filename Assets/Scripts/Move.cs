using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    
    public float initColForce = 200;
    public float colForce = 200;
    public float maxColForce = 400;
    public string up;
    public string down;
    public string left;
    public string right;
    Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
	}

    void SetMovementDir(Rigidbody myRB, string key, Vector3 direction, float initForce, float collidingForce)
    {
        if (Input.GetKey(key))
        {
            if (collidingForce < maxColForce)
            {
                collidingForce += colForce * Time.deltaTime;
            }
            myRB.AddForce(direction * Time.deltaTime * collidingForce);
        };
        if (Input.GetKeyUp(key))
        {
            collidingForce = initForce;
        }
    }

    void Movement()
    {

        SetMovementDir(rb, up, Vector3.forward, initColForce, colForce);
        SetMovementDir(rb, down, Vector3.back, initColForce, colForce);
        SetMovementDir(rb, left, Vector3.left, initColForce, colForce);
        SetMovementDir(rb, right, Vector3.right, initColForce, colForce);
    }
}
