using UnityEngine;
using System.Collections;

public class Smash : MonoBehaviour {
    public AudioClip smash;
    AudioSource dash;
    Rigidbody Player;
    public Rigidbody Target;
    public KeyCode SmashKey;
    public int SmashForce;
    CollectFood food;
    float cooldown = 3;
	// Use this for initialization
	void Start ()
    {
       
        dash = GetComponent<AudioSource>();
	    Player = GetComponent<Rigidbody>();
        food = GetComponent<CollectFood>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        cooldown -= Time.deltaTime;
	    if (Input.GetKeyDown(SmashKey)&& food.energy>0&&cooldown<0)
        {
            dash.PlayOneShot(smash,1);
            if (Vector3.Distance(Player.position, Target.position )< 4)
            {
                Player.velocity = new Vector3(0,0,0);
                Player.AddForce(Vector3.Normalize(Target.position - Player.position + Vector3.Normalize(Target.velocity)) * SmashForce);
                
            }
            else
            {
                Player.AddForce(Vector3.Normalize(Player.velocity) * SmashForce);
            }
            food.Shrink();
            cooldown = 3;
        }
	}
}
