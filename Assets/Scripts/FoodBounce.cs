using UnityEngine;
using System.Collections;

public class FoodBounce : MonoBehaviour
{
    int bounceLife = 1;

    void OnCollisionEnter(Collision collision)
    {
        /*
         * NOTES:
         * - Vector3.[direction]
         * - Random.Range(minVel, maxVel);
         *                 = Make minVel/ maxVel public for easier editing
         *
         *   If you need anymore direction with this look at Pig_LegController.cs on my
         *   Git repo Physics_Assessment 
         *                                  -Jared was here
        */

        //One more thing, I suggest a switch statement on this -Jared
        if (collision.gameObject.tag == "Ground")
        {
            bounceLife -= 1;
            GetComponent<Rigidbody>().velocity += Vector3.back * Random.Range(0, 5);
        }

    }
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
