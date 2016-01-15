using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    
    float InitColForce = 200;
    float ColForce = 200;
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
            if (collidingForce < 500)
            {
                collidingForce += 200 * Time.deltaTime;
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

        SetMovementDir(rb, up, Vector3.forward, InitColForce, ColForce);
        SetMovementDir(rb, down, Vector3.back, InitColForce, ColForce);
        SetMovementDir(rb, left, Vector3.left, InitColForce, ColForce);
        SetMovementDir(rb, right, Vector3.right, InitColForce, ColForce);
    }
}
