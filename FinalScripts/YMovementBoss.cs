using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YMovementBoss : MonoBehaviour
{
    public Vector3 target;
    public float speed;

    void Start() {
        target = new Vector3(transform.position.x, -8.69f);
     }

        
      void Update() {
         transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
       
    }



}