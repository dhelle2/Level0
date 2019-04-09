using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escape : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public InputField inputField;
    public GameObject door;
    public GameObject doorButton;
    public AudioSource room1Audio;
    public GameObject room1;
    public Button oneButton;


    // Start is called before the first frame update
    void Start()
    {
        //doorButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void oneButtonPressed()
    {
        inputField.text += "1";
    }

    public void checkEscapeAndEscape() {
        if (inputField.text == "12")
        {
            doorButton.gameObject.SetActive(true);
            room1Audio = room1.GetComponent<AudioSource>();
            room1Audio.Stop();
            door.GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().Play();
            //player1.GetComponent<Rigidbody>().transform.position += new Vector3(0F, 0F, -100F);
            //player2.GetComponent<Rigidbody>().transform.position += new Vector3(0F, 0F, -100F);
            door.SetActive(false);
            player1.GetComponent<Rigidbody>().useGravity = false;
            player2.GetComponent<Rigidbody>().useGravity = false;

        }
    }
}
