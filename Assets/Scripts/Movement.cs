﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Rigidbody rb;

// Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    void Move()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * Time.deltaTime*200);
        };
        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * Time.deltaTime* 200);
        };
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * Time.deltaTime * 200);
        };
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * Time.deltaTime * 200);
        };
    }
}
