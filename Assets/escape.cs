using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escape : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkEscapeAndEscape() {
        if (inputField.text == "12")
        {
            player1.GetComponent<Rigidbody>().transform.position += new Vector3(0F, 0F, -100F);
            player2.GetComponent<Rigidbody>().transform.position += new Vector3(0F, 0F, -100F);
        }
    }
}
