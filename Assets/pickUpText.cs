using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpText : MonoBehaviour
{
    public bool showing = false;

    void Update() {
        if (showing)
        {
            gameObject.SetActive(true);
        }
        else {
            gameObject.SetActive(false);
        }
    }
}
