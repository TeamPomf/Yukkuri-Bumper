using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class CustomCollision : MonoBehaviour {

    public Rigidbody p1rb;
    public Rigidbody p2rb;
    AudioSource collideSound;



    void Start ()
    {
         collideSound = GetComponent<AudioSource>();
	}
	void Update ()
    {
       
       
        p1rb.AddForce(Physics.gravity*Time.deltaTime);
        p2rb.AddForce(Physics.gravity*Time.deltaTime);
    }
    void OnTriggerEnter(Collider rb)
    {

        if (rb.gameObject.tag == "Player" && p1rb.mass * p1rb.velocity.magnitude < p2rb.mass * p2rb.velocity.magnitude)
        {
            //PUT ADVANCED COLLISION STUFF HERE
            p1rb.AddForce((Vector3.up + p1rb.position - p2rb.position) * 10);
            p2rb.AddForce((p2rb.position - p1rb.position) * 10);
        }
        if (rb.gameObject.tag == "Player" && p1rb.mass * p1rb.velocity.magnitude > p2rb.mass * p2rb.velocity.magnitude)
        {
            //AND HERE
            p2rb.AddForce((Vector3.up + p2rb.position - p1rb.position) * 10);
            p1rb.AddForce((p1rb.position - p2rb.position) * 10);
        }
        if (rb.gameObject.tag == "Player")
        {
            collideSound.Play();
        }
    }
}
