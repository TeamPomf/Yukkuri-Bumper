using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour
{
    Rigidbody rb;

    public Vector3 dir;

    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(dir);
    }
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
