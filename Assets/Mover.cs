﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //these variables change our movement speed
    [SerializeField] float xValue = 0.0f;
    [SerializeField] float yValue = 0.0f;
    [SerializeField] float zValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
