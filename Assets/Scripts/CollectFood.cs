using UnityEngine;
using System.Collections;

public class CollectFood : MonoBehaviour
{
    Rigidbody rb;
    Move playerMovement;
    
    void OnCollisionEnter(Collision food)
    {

        if (food.gameObject.tag == "Food")
        {
            Grow();
            Destroy(food.gameObject);
        }
        if (food.gameObject.tag == "FoodBad")
        {
            Shrink();
            Destroy(food.gameObject);
        }
        if (food.gameObject.tag == "FoodSpeed")
        {
            Speed();
            Destroy(food.gameObject);
        }
    }
 

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        playerMovement = GetComponent<Move>();
    }
	
	
	void Update ()
    {
       
     
    }
    void Grow()
    {
        rb.mass += .0025f;
        transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
    }
    void Shrink()
    {
        //NOT ALLOWED TO DO THIS IN A CHRISTIAN CODEBASE transform.localScale > Vector3(0.75f,0.75f,0.75f)
        if (transform.localScale.x > 0.75f && transform.localScale.y > 0.75f && transform.localScale.z > 0.75f )
        {
            rb.mass -= .0015f;
            transform.localScale -= new Vector3(0.025f, 0.025f, 0.025f);
        }
        
    }
    void Speed()
    {
        playerMovement.colForce += 50;
        playerMovement.initColForce += 50;
        playerMovement.maxColForce += 50;
    }


}
