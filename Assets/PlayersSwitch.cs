using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersSwitch : MonoBehaviour
{

    public GameObject player2;
    public GameObject player1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doSwitch()
    {
        if (player2.activeInHierarchy)
        {
            player2.SetActive(false);
        }
        else
        {
            player2.SetActive(true);
        }
        if (player1.activeInHierarchy)
        {
            player1.SetActive(false);
        }
        else
        {
            player1.SetActive(true);
        }
    }
}
