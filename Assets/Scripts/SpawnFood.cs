using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {

    public GameObject food0;
    public GameObject food1;
    public int foodToSpawn = 40;
    public float timeRange = 3;

    public GameObject[] foodStuff;
    

	void Start ()
    {
        StartCoroutine(Spawn(food0,foodToSpawn,timeRange));
        //StartCoroutine(Spawn(food1, foodToSpawn, timeRange));

    }



	void Update ()
    {
	
	}
    

    IEnumerator Spawn(GameObject prefab, int amount, float timeRange)
    {
      
        for (int i = 0; i < amount; i++)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            
            yield return new WaitForSeconds(Random.Range(0.0f, timeRange));
        }
        
    }

   
}
