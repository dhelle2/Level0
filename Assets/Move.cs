using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position += new Vector3(.1F, 0F, 0F);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position += new Vector3(-.1F, 0F, 0F);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position += new Vector3(0F, 0F, .1F);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position += new Vector3(0F, 0F, -.1F);
        }
    }
}
