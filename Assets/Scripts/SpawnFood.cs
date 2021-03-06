﻿using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {
    [SerializeField]
    GameObject[] food;
    [SerializeField]
    GameObject[] badfood;
    
    [SerializeField]
    CameraFocus foo;
    public int foodToSpawn = 40;
    public int food0Delay = 5;
    public int food1Delay = 9;
    public int food2Delay = 15;
    public float minTime = 8;
    public float maxTime = 10;
    int foodpoop = 40;
 


    void Start ()  
    {
       StartCoroutine(Spawn(foodToSpawn,minTime, maxTime, food0Delay));


      //  StartCoroutine(Spawn(food1, foodToSpawn,minTime, maxTime + 30, food1Delay));
       // StartCoroutine(Spawn(food2, foodToSpawn,minTime, maxTime + 40, food2Delay));//hacky, but it will display as unassigned reference if we do not put anything in here regardless if we need it or not

    }



	void Update ()
    {
        if (foo.playerWin == -1 && foodpoop > 0)
        {
            StartCoroutine(Spawn(20, 1, 2, 2, false));
            foodpoop--;
        }

    }
    

    IEnumerator Spawn(int amount, float timeMin, float timeMax, float delay)
    {

        yield return new WaitForSeconds(delay);
        Random.Range(0, 100);
        for (int i = 0; i < amount; i++)
        {
            if (Random.Range(0, 9) < 7)
            {
                Instantiate(badfood[Random.Range(0, 6)], transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(food[Random.Range(0, 6)], transform.position, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        }
        
    }
    IEnumerator Spawn(int amount, float timeMin, float timeMax, float delay, bool f)
    {

        yield return new WaitForSeconds(delay);
        Random.Range(0, 100);
        for (int i = 0; i < amount; i++)
        {
            Instantiate(badfood[Random.Range(0, 6)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
        }

    }


}
