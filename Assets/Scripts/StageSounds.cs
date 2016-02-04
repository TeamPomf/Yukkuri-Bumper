using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class StageSounds : MonoBehaviour {
    AudioSource bgm;
  
    void Start () {
        bgm = GetComponent<AudioSource>();        
        bgm.Play();
    }
    void Update ()
    {
    }
    
    
}
