using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemPlayerDetection : MonoBehaviour
{
   
    public Transform other;
    public bool gemStolen = false;
    void Update() {
        if (other) {
            float dist = Vector3.Distance(other.position, transform.position);
            if (dist < 5)
            {
 
                if (Input.GetKeyDown(KeyCode.E)) {
                    FindObjectOfType<AudioManager>().Play("Take");
                    gemStolen = true;
                    Destroy(gameObject);
                }
            }
           
                
            
        }
    }
    
}
