using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {
    [SerializeField]
    GameObject food0;
    [SerializeField]
    GameObject food1;
    [SerializeField]
    GameObject food2;
    public int foodToSpawn = 40;
    public int food0Delay = 5;
    public int food1Delay = 9;
    public int food2Delay = 15;
    public float minTime = 8;
    public float maxTime = 10;
    

	void Start ()
    {
        StartCoroutine(Spawn(food0,foodToSpawn,minTime, maxTime, food0Delay));
        StartCoroutine(Spawn(food1, foodToSpawn,minTime, maxTime + 30, food1Delay));
        StartCoroutine(Spawn(food2, foodToSpawn,minTime, maxTime + 40, food2Delay));
    }



	void Update ()
    {
	
	}
    

    IEnumerator Spawn(GameObject prefab, int amount, float timeMin, float timeMax, float delay)
    {

        yield return new WaitForSeconds(delay);

        for (int i = 0; i < amount; i++)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            
            yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        }
        
    }

   
}
