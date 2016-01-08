using UnityEngine;
using System.Collections;

public class CollectFood : MonoBehaviour
{
    Rigidbody rb;
    void OnCollisionEnter(Collision food)
    {

        if (food.gameObject.tag == "Food")
        {
            Grow();
            Destroy(food.gameObject);
        }
        if (food.gameObject.tag == "BadFood")
        {
            Shrink();
            Destroy(food.gameObject);
        }
    }
 

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
     
    }
    void Grow()
    {
        rb.mass += .005f;
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
    void Shrink()
    {
        //transform.localScale > Vector3(0.75f,0.75f,0.75f)
        if (transform.localScale.x > 0.75f && transform.localScale.y > 0.75f && transform.localScale.z > 0.75f )
        {
            rb.mass -= .0025f;
            transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
        }
        
    }


}
