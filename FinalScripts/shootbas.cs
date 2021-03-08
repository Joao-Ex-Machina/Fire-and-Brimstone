using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbas : MonoBehaviour
{
    public int damage = 1;
    public Rigidbody2D rb;
    public GameObject ImpactEf;
    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        EnemyBoss boss = hitInfo.GetComponent<EnemyBoss>();
        EnemyBoss2 boss2 = hitInfo.GetComponent<EnemyBoss2>();
        CanonEnemy canon = hitInfo.GetComponent<CanonEnemy>();
        if (enemy!=null)
        {
            enemy.TakeDamage(damage);
        }
       
         if (boss!=null)
        {
            boss.TakeDamage(damage);
        }
         if (boss2!=null)
        {
            boss2.TakeDamage(damage);
        }

         if (canon!=null)
        {
            canon.TakeDamage(damage);
        
        }
        Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);

        
    }
    
         void OnBecameInvisible() {
             Destroy(gameObject);
         }
}
