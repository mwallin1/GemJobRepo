using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] target;
 
    public float speed;
    public float rotSpeed;
    private int current;
    Vector3 pos;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position != target[current].position)
        {
            Vector3 targetDirection = target[current].position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            
          
           
            pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            
        }
        else {
            
            current = (current + 1) % target.Length;
           
            

        }
    }

    
    
}
