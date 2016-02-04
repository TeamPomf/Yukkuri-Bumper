using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class PlayFoodSound : MonoBehaviour {
    AudioSource foodDrop;
	void Start () {
        foodDrop = GetComponent<AudioSource>();

	}
		void Update () {
	
	}
    void OnCollisionEnter(Collision ground)
    {

        if (ground.gameObject.tag == "Arena")
        {
            foodDrop.Play();
        }       
    }
}
