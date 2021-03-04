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
        if (enemy!=null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);
    }
}
