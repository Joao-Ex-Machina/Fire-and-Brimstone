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
        if (player!=null)
        {
            player.TakeDamage(damage);
            Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);
        }
        
    }
}
