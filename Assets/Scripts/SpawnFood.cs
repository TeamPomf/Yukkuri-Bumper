using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {

    public GameObject[] foodStuff;

	void Start ()
    {
        foreach (var food in foodStuff)
        {
            Instantiate(food, transform.position, Quaternion.identity);
        }
        
    }
	
	void Update ()
    {
	
	}
}
