using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Rigidbody rb;
    public Rigidbody opponentrb;
    public float initColForce = 200;
    public float colForce = 200;

    //void OnCollisionEnter(Collision opponent)
    //{

    //    if (opponent.gameObject.tag == "Player")
    //    {
           
    //        //default value of collision force = 50 unless otherwise edited by user
    //        rb.AddForce(Vector3.Normalize(Vector3.Reflect(rb.position, -opponentrb.position))*collisionForce);

    //    }
    //}
    void Move()
    {

        SetMovementDir("w", Vector3.forward);
        SetMovementDir("s", Vector3.back);
        SetMovementDir("a", Vector3.left);
        SetMovementDir("d", Vector3.right);
        //if (Input.GetKey("w"))
        //{
        //    colForce += 10 * Time.deltaTime;
        //    rb.AddForce(Vector3.forward * Time.deltaTime * colForce);                      
        //};
        //if (Input.GetKey("s"))
        //{
        //    colForce += 10 * Time.deltaTime;
        //    rb.AddForce(Vector3.back * Time.deltaTime * colForce); 

        //};
        //if (Input.GetKey("a"))
        //{
        //    colForce += 10 * Time.deltaTime;
        //    rb.AddForce(Vector3.left * Time.deltaTime * colForce);

        //};
        //if (Input.GetKey("d"))
        //{
        //    colForce += 10 * Time.deltaTime;
        //    rb.AddForce(Vector3.right * Time.deltaTime * colForce);     

        //};

    }
    void SetMovementDir(string key, Vector3 direction)
    {
        if (Input.GetKey(key))
        {
            if (colForce < 500)
            {
                colForce += 200 * Time.deltaTime;
            }
            
            rb.AddForce(direction * Time.deltaTime * colForce);
        };
        if (Input.GetKeyUp(key))
        {
            colForce = initColForce;
        }
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
