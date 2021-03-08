using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMovementBoss : MonoBehaviour
{
   // repurpose do PlayerMovement.cs
   private float speed = 0.3f;
    public Rigidbody2D rb2d;
     Vector2 movement;
  
    void Update()
    {
      movement.x = Input.GetAxisRaw ("Horizontal"); 
       movement.y = 0;
}

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * speed* Time.fixedDeltaTime);
    }

}

