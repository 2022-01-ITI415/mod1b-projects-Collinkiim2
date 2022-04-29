using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject ballPrefab;

    public float speed = 1f;
    public float leftAndRightEdge = 1f;
    public float chanceToChangeDirection = 0.1f;
    public float secondsBetweenBallDrop = 1f;
    
    
    void Start()
    {
        Invoke ("DropBall", 2f);
    }

    void DropBall()
    {
        // question about this code

        GameObject ball = Instantiate < GameObject> (ballPrefab);
        ball.transform.position = transform.position;
        Invoke ("DropBall", secondsBetweenBallDrop);
    }

    
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

    void FixedUpdate() {
 
        if ( Random.value < chanceToChangeDirection)
        {
            speed *= -1;
        }
 
    }
    
 
}