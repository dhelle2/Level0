﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float spd = 1f;
    private Animator animator;
    bool Walk;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        //Walk = false;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", move);


        if (Input.GetButtonDown("Fire3"))
        {
            spd = 3f;
            //print("You hittin it");
        }
        if (Input.GetButtonUp("Fire3"))
        {
            spd = 1f;
            //print("You ain't");
        }

        if (Input.GetKey(KeyCode.W))
        {
            //rb.transform.position += new Vector3(.1F, 0F, 0F);
            rb.transform.Translate(0f, 0f, spd);
        }
     

        if (Input.GetKey(KeyCode.A))
        {
           //rb.transform.position += new Vector3(0F, 0F, .1F);
            rb.transform.Rotate(0, spd*-3f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rb.transform.position += new Vector3(-.1F, 0F, 0F);
            rb.transform.Translate(0f, 0f, -spd);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //rb.transform.position += new Vector3(0F, 0F, -.1F);
            rb.transform.Rotate(0, spd*3f, 0);
        }
       
    }
}
