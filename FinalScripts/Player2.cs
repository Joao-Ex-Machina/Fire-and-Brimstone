using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int maxhealth = 9;
    public static int currenthealth;
    public healthbar healthbar;
    public GameObject deathEf;
     void Start ()
    {
      currenthealth =  maxhealth;
      healthbar.SetMaxHealth(maxhealth);

    }

    public void TakeDamage (int damage)
    {
        currenthealth -= damage;
        healthbar.SetHealth (currenthealth);
        if (currenthealth <= 0)
        {
            Die();
        }
    }
    void Update () {
		 healthbar.SetHealth (currenthealth);
	}
    void Die ()
    {
        Instantiate(deathEf, transform.position, Quaternion.identity);
        Destroy (gameObject);
        FindObjectOfType<GManager2>().GameOver2();
    }
}
