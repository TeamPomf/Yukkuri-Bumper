using UnityEngine;
using System.Collections;

public class Bump : MonoBehaviour {

    public Rigidbody opponent;
    void OnCollisionEnter(Collision opponent)
    {

        if (opponent.gameObject.tag == "Player")
        {
          
        }
        
    }
    void Start ()
    {
        opponent.
	}
	
	void Update ()
    {
	
	}

}
