using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class BreakGate : MonoBehaviour {
    AudioSource gateBreak;
    [SerializeField]
    SpringJoint gate;
    int foo;
	void Start () {
        gateBreak = GetComponent<AudioSource>();
        foo = 0;
    }
	
	void Update () {
        if (gate == null&&foo==0)
        {
            gateBreak.Play();
            foo = 1;
        }
    }
}
