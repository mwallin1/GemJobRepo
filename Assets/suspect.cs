using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspect : MonoBehaviour
{
    float coolDown = 15f;
    bool wait = false;
    public Transform other;
    public playerModel pm;
   

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(other.position, transform.position);
        if (pm.zombSuit == true)
        {
            FindObjectOfType<AudioManager>().Mute("Grunt");
            if (dist < 5f)
            {
                FindObjectOfType<AudioManager>().Play("Scream");
                Destroy(gameObject);
            }
        }
        if (pm.trashSuit == true)
        {
            FindObjectOfType<AudioManager>().Mute("Grunt");
            if (dist < 5f)
            {
                FindObjectOfType<AudioManager>().Play("Hit");
                Destroy(gameObject);
            }
        }
        if (pm.guardSuit == true)
        {
            if (dist < 5f)
            {
                FindObjectOfType<Manager>().gameOverC();
            }
        }
        if (pm.zombSuit == false && pm.trashSuit == false && pm.guardSuit == false)
        {
            if (dist < 15f)
            {
                FindObjectOfType<Manager>().gameOver();
            }
            if (dist < 20f && wait == false)
            {

                FindObjectOfType<AudioManager>().Play("Grunt");
                wait = true;
            }
            if (wait == true)
            {

                coolDown -= Time.deltaTime;
                if (coolDown <= 0)
                {
                    coolDown = 3f;
                    wait = false;
                }
            }
        }
        
        
    }
}
