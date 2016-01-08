using UnityEngine;
using System.Collections;

public class CollectFood : MonoBehaviour
{

    void OnCollisionEnter(Collision food)
    {

        if (food.gameObject.tag == "Food")
        {
            Grow();
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
        gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }


    
}
