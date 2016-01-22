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
    public float minTime = 4;
    public float maxTime = 10;

    public GameObject[] foodStuff;
    

	void Start ()
    {
        StartCoroutine(Spawn(food0,foodToSpawn,minTime, maxTime));
        StartCoroutine(Spawn(food1, foodToSpawn,minTime, maxTime + 20));
        StartCoroutine(Spawn(food2, foodToSpawn,minTime, maxTime + 20));
    }



	void Update ()
    {
	
	}
    

    IEnumerator Spawn(GameObject prefab, int amount, float timeMin, float timeMax)
    {
      
        for (int i = 0; i < amount; i++)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            
            yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        }
        
    }

   
}
