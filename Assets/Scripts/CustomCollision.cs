using UnityEngine;
using System.Collections;

public class CustomCollision : MonoBehaviour {

    public Rigidbody p1rb;
    public Rigidbody p2rb;

    void OnTriggerEnter(Collider rb)
    {

        if (rb.gameObject.tag == "Player"&& p1rb.mass<p2rb.mass)
        {
           //PUT ADVANCED COLLISION STUFF HERE
            p1rb.AddForce(Vector3.up*100);            
        }
        if (rb.gameObject.tag == "Player" && p1rb.mass>p2rb.mass)
        {
            //AND HERE
            p2rb.AddForce(Vector3.up * 100);
        }
    }
   
   

    void Start ()
    {
        
	}
	void Update ()
    {
       
       
        p1rb.AddForce(Physics.gravity*Time.deltaTime);
        p2rb.AddForce(Physics.gravity*Time.deltaTime);
    }
 
}
