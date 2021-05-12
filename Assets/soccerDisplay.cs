using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccerDisplay : MonoBehaviour
{
    public Transform other;
    public playerModel pm;
    public pMovement pMov;

    void Update()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            if (dist < 5)
            {

                if (Input.GetKeyDown(KeyCode.E))
                {

                    pm.switchModelSoccer();
                    pMov.speed = 20f;
                    Destroy(gameObject);
                    FindObjectOfType<AudioManager>().UnMute("Theme");
                    FindObjectOfType<AudioManager>().Mute("Christmas");
                    FindObjectOfType<AudioManager>().Play("Ref");
                }
            }



        }
    }

}
