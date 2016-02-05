using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class CollectFood : MonoBehaviour
{
   public AudioClip munch;
    AudioSource sourceMunch;
    Rigidbody rb;
    Move playerMovement;
    public float energy;
    float ballScale = .5f;
    float massIncrement = 0.01f;

    [SerializeField]        // lets you keep a member variable private, but exposed to the Inspector
    Material normalFace;
    [SerializeField]
    Material eatingFace;
    [SerializeField]
    CameraFocus foo;
    MeshRenderer render;
    float nomnomTimer = 0.0f;

    
 

    void Start ()
    {
        sourceMunch = GetComponent<AudioSource>();
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
    void Grow()
    {
        if (energy < 5 || (foo.playerWin == -1 && energy < 20))
        {
            energy += 1;
            transform.localScale = new Vector3(ballScale, ballScale, ballScale) * energy;
            rb.mass = energy * massIncrement;
            playerMovement.colForce += 10;
            playerMovement.initColForce += 10;
            playerMovement.maxColForce += 10;

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
            playerMovement.colForce -= 10;
            playerMovement.initColForce -= 10;
            playerMovement.maxColForce -= 10;
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
            sourceMunch.PlayOneShot(munch,1);
            Grow();
            Destroy(food.gameObject);
            nomnomTimer = 0.5f;
        }
        if (food.gameObject.tag == "FoodBad")
        {
            sourceMunch.PlayOneShot(munch, 1); Shrink();
            Destroy(food.gameObject);
            nomnomTimer = 0.5f;
        }
        if (food.gameObject.tag == "FoodSpeed")
        {
            sourceMunch.PlayOneShot(munch, 1); Speed();
            Destroy(food.gameObject);
            nomnomTimer = 0.5f;
        }
    }


}
