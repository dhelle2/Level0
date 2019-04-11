using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorButtonPress : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;

    public GameObject doorButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doorBPressed()
    {
        playerOne.transform.position = new Vector3(440F, 1.96F, -721F);
        doorButton.gameObject.SetActive(false);
    }
}
