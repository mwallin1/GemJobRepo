using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaving : MonoBehaviour
{
    public gemPlayerDetection g;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && g.gemStolen == true)
        {
            FindObjectOfType<Manager>().endScreen();
        }
    }
}
