using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //definir var editavel no layout do unity
    public Rigidbody2D rb2d;
    public Animator animator;
     Vector2 movement;
  
    void Update()
    {
      movement.x = Input.GetAxisRaw ("Horizontal"); 
      
      animator.SetFloat("roll", movement.x);
       movement.y = Input.GetAxisRaw ("Vertical");
    }
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * speed* Time.fixedDeltaTime);
    }
}


