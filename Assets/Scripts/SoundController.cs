using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour {
    GameObject p1;
    GameObject p2;

	void Start () {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
