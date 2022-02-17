using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public static float  bottomY= -1f;

    // Update is called once per frame
    void Update() {
        if ( transform.position.y < bottomY ) {
            Destroy( this.gameObject );
        }
    }
    
}
