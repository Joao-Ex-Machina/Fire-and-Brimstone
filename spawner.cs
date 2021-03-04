using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    float randx;
    Vector2 spawnerSite;
    public float SpawnRate;
    float nextspawn =0.0f ;
  
    void Update()
    {
        if(Time.time > nextspawn) 
          { 
              nextspawn = Time.time + SpawnRate;
              randx = Random.Range (-1.28f , 1.27f);
              spawnerSite = new Vector2 (randx , transform.position.y);
              Instantiate (enemy, spawnerSite,Quaternion.identity);
              
              }
    }
}
