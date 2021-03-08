using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCoin : MonoBehaviour
{
     public Rigidbody2D rb;
    public GameObject ImpactEf;
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player!=null)
        {
            Score.ScoreBoost += 50;
            Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);
        }
        Player2 player2 = hitInfo.GetComponent<Player2>();
        if (player2!=null)
        {
            Score.ScoreBoost += 50;
            Instantiate (ImpactEf, transform.position, transform.rotation);
        Destroy (gameObject);
        }
      }
           void OnBecameInvisible() {
             Destroy(gameObject);
         }
}
