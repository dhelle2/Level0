﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCanvas : MonoBehaviour
{
    public GameObject gui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        gui.GetComponent<Canvas>().enabled = true;
    }
}
