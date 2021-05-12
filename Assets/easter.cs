using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easter : MonoBehaviour
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
                    FindObjectOfType<AudioManager>().Mute("Christmas");
                    FindObjectOfType<AudioManager>().UnMute("Theme"); 
                    pm.switchModelTrash();
                    pMov.speed = 25f;
                    Destroy(gameObject);
                    FindObjectOfType<AudioManager>().Play("Egg");
                }
            }



        }
    }
}
