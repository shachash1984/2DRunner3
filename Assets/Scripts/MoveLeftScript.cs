﻿using UnityEngine;
using System.Collections;

public class MoveLeftScript : MonoBehaviour {

    public float speed = 3f;

   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
	}
}
