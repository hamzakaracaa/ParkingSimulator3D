using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    
    private float xLimit = -250;

   
    void Update()
    {
        // Destroy animals if x position less than X limit
        if (transform.position.x < xLimit)
        {
            Destroy(gameObject);
        } 
    }
}
