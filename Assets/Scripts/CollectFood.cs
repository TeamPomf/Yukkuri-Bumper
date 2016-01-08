using UnityEngine;
using System.Collections;

public class CollectFood : MonoBehaviour
{

    void OnCollisionEnter(Collision food)
    {

        if (food.gameObject.tag == "Food")
        {

            Destroy(food.gameObject);
        }

    }

    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
       
     
    }
    void Grow()
    {
       // transform.localScale.x 
    }
    
}
