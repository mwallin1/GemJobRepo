using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard_PlayerDetection : MonoBehaviour
{
    public playerModel pm;
    public Transform t;
    bool caught = false;
    float dist;

    public void Update()
    {
        dist = Vector3.Distance(t.position, transform.position);
     
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player") {
            if (pm.zombSuit == true)
            {
                FindObjectOfType<AudioManager>().Play("Scream");
                Destroy(gameObject);

            }
            

            
            if (pm.trashSuit == true)
            {
                FindObjectOfType<AudioManager>().Play("Hit");
                Destroy(gameObject);

            }
            if(pm.trashSuit != true && pm.zombSuit != true)
            {
                FindObjectOfType<Manager>().gameOver();
            }
        }
    }
}

   

   


   

