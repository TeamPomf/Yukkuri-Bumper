﻿using UnityEngine;
using System.Collections;

public class ButterClick : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
    public void ArenaOneClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void ArenaTwoClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

	// Update is called once per frame
	void Update ()
    {
	
	}
}
