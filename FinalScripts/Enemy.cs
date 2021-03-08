using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 2;
    public int Points = 2;
    public GameObject deathEf;
    public float dropchance1;
    public float dropchance2;
    private float chance = 100;
    public GameObject Powerup1;
    public GameObject Powerup2;
    

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
        chance = Random.Range(0, 100);
        Instantiate(deathEf, transform.position, Quaternion.identity);
        if (chance <= dropchance1){
            Instantiate(Powerup1, transform.position, Quaternion.identity);
        }
         if (chance <= dropchance2){
             Instantiate(Powerup2, transform.position, Quaternion.identity);
        }
        
        Destroy (gameObject);
        Score.ScoreValue += Points;
        chance = Random.Range(0, 100);
    }
         void OnBecameInvisible() {
             Destroy(gameObject);
         }
}