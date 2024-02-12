using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {
            
            Movement movement = other.GetComponent<Movement>();
            if (movement != null) 
            {
                
                movement.Respawn(); 
            }
        }
    }
}

