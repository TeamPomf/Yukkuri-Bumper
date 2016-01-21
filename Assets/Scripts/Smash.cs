using UnityEngine;
using System.Collections;

public class Smash : MonoBehaviour {

    Rigidbody Player;
    public Rigidbody Target;
    public KeyCode SmashKey;
    public int SmashForce;
	// Use this for initialization
	void Start ()
    {
	    Player = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(SmashKey))
        {
            if (Vector3.Distance(Player.position, Target.position )< 4)
            {
                Player.velocity = new Vector3(0,0,0);
                Player.AddForce(Vector3.Normalize(Target.position - Player.position + Vector3.Normalize(Target.velocity)) * SmashForce);
            }
            else
            {
                Player.AddForce(Vector3.Normalize(Player.velocity) * SmashForce);
            }
        }
	}
}
