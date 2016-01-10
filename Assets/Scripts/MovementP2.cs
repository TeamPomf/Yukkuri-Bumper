using UnityEngine;
using System.Collections;

public class MovementP2 : MonoBehaviour {
    Rigidbody rb;
    public Rigidbody opponentrb;
    void OnCollisionEnter(Collision opponent)
    {

        if (opponent.gameObject.tag == "Player")
        {

            rb.AddForce(Vector3.Reflect(rb.position.normalized, opponentrb.position.normalized));

        }
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
