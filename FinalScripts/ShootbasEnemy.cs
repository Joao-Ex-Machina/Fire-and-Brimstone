using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootbasEnemy : MonoBehaviour
{
    public int damage = 1;
    public Rigidbody2D rb;
    public GameObject ImpactEf;
   
    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
         Player2 player2 = hitInfo.GetComponent<Player2>();
        if (player!=null)
        {
            player.TakeDamage(damage);
            Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);
        }
        if (player2!=null)
        {
            player2.TakeDamage(damage);
            Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);
        }
        
    }
         void OnBecameInvisible() {
             Destroy(gameObject);
         }
}
