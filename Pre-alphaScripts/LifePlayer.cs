using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePlayer : MonoBehaviour
{
    public int health = 6;
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
    }
}
