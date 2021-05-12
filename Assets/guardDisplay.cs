﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardDisplay : MonoBehaviour
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

                    pm.switchModelGuard();
                    pMov.speed = 10f;
                    Destroy(gameObject);
                    FindObjectOfType<AudioManager>().Mute("Christmas");
                    FindObjectOfType<AudioManager>().UnMute("Theme"); ;
                    FindObjectOfType<AudioManager>().Play("Guard");
                }
            }



        }
    }

}
