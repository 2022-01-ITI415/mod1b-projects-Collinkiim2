using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadWall : MonoBehaviour
{
    [Header("Set in Inspector")]

    public float speed = 1f;
    public float leftAndRightEdge = 1f;
    
    void Update()
    {
        Vector3 pos = transform.position;      
        pos.x += speed * Time.deltaTime;       
        transform.position = pos;    

        if ( pos.x < -leftAndRightEdge ) 
        {      
           speed = Mathf.Abs(speed); 
       } else if ( pos.x > leftAndRightEdge ) {
           speed = -Mathf.Abs(speed); 
       }
    }
    
 
}