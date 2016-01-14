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
	
	
	void Update ()
    {
       
     
    }
    void Grow()
    {
        rb.mass += .025f;
        transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
    }
    void Shrink()
    {
        //NOT ALLOWED TO DO THIS IN A CHRISTIAN CODEBASE transform.localScale > Vector3(0.75f,0.75f,0.75f)
        if (transform.localScale.x > 0.75f && transform.localScale.y > 0.75f && transform.localScale.z > 0.75f )
        {
            rb.mass -= .015f;
            transform.localScale -= new Vector3(0.25f, 0.25f, 0.25f);
        }
        
    }


}
