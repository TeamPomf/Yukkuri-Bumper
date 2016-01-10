using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Rigidbody rb;
    public Rigidbody opponentrb;

    void OnCollisionEnter(Collision opponent)
    {

        if (opponent.gameObject.tag == "Player")
        {
           
            rb.AddForce(Vector3.Normalize(Vector3.Reflect(rb.position, opponentrb.position))*50);

        }
    }
    void Move()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * Time.deltaTime * 200);
        };
        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * Time.deltaTime * 200);
        };
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * Time.deltaTime * 200);
        };
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * Time.deltaTime * 200);
        };
    }

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}
 
}
