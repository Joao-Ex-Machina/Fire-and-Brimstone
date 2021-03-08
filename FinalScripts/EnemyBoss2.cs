using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss2 : MonoBehaviour
{
    
    public int health = 2;
    public int Points = 2;
    public GameObject deathEf;
    
    

    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die ()
    {
        Instantiate(deathEf, transform.position, Quaternion.identity);
        Destroy (gameObject);
        Score.ScoreValue += Points;
        FindObjectOfType<GManager2>().Victory();
       
    }
        
}
