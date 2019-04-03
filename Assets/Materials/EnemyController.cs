using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public Transform myTransform;
    Animator anim;
    Vector3 startPos;



    private void Start()
    {
        anim = GetComponent<Animator>();
      
        startPos = this.transform.position;

    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(2);
        this.transform.position = startPos;
        anim.ResetTrigger("trigger1");

    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(player.position, transform.position);


        if (distance < 15)
        {
            anim.SetTrigger("trigger1");

            StartCoroutine(Example());

        }



        transform.LookAt(player);
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);

    }
}