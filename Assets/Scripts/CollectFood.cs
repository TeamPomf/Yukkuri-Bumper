using UnityEngine;
using System.Collections;

public class CollectFood : MonoBehaviour
{
    Rigidbody rb;
    Move playerMovement;
    public float energy;
    float ballScale = .5f;
    float massIncrement = 0.01f;

    [SerializeField]        // lets you keep a member variable private, but exposed to the Inspector
    Material normalFace;

    [SerializeField]
    Material eatingFace;

    MeshRenderer render;

    float nomnomTimer = 0.0f;

    void Grow()
    {
        if (energy < 5)
        {
            energy += 1;
            transform.localScale = new Vector3(ballScale, ballScale, ballScale) * energy;
            rb.mass = energy * massIncrement;

        }

    }
    public void Shrink()
    {
        //NOT ALLOWED TO DO THIS IN A CHRISTIAN CODEBASE transform.localScale > Vector3(0.75f,0.75f,0.75f)
        //if (transform.localScale.x > 0.75f && transform.localScale.y > 0.75f && transform.localScale.z > 0.75f )
        //{
        //    rb.mass -= .0015f;
        //    transform.localScale -= new Vector3(0.025f, 0.025f, 0.025f);
        //}
        if (energy > 1)
        {
            energy -= 1;
            transform.localScale = new Vector3(ballScale, ballScale, ballScale) * energy;
            rb.mass = massIncrement * energy;
        }


    }
    void Speed()
    {
        playerMovement.colForce += 50;
        playerMovement.initColForce += 50;
        playerMovement.maxColForce += 50;
    }

    void OnCollisionEnter(Collision food)
    {

        if (food.gameObject.tag == "Food")
        {
            Grow();
            Destroy(food.gameObject);
            nomnomTimer = 0.5f;
        }
        if (food.gameObject.tag == "FoodBad")
        {
            Shrink();
            Destroy(food.gameObject);
            nomnomTimer = 0.5f;
        }
        if (food.gameObject.tag == "FoodSpeed")
        {
            Speed();
            Destroy(food.gameObject);
            nomnomTimer = 0.5f;
        }
    }
 

    void Start ()
    {
        energy = 3;
        transform.localScale = new Vector3(ballScale, ballScale, ballScale) * energy;
        
        rb = GetComponent<Rigidbody>();
        render = GetComponent<MeshRenderer>();
        playerMovement = GetComponent<Move>();
        rb.mass = energy * massIncrement;
    }
	
	
	void Update ()
    {
        nomnomTimer -= Time.deltaTime;
       if (nomnomTimer > 0.0f)
        {
            render.material = eatingFace;
        }
       else
        {
            render.material = normalFace;
        }
     
    }
    


}
