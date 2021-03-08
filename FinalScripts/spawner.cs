using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject nothing;
    float randx;
    Vector2 spawnerSite;
    public float SpawnRate;
    public int progressionCMin;
    public int progressionCMax;
    float nextspawn =0.0f ;
  
    void Update()
    {
        if(progressionCMin > Score.ScoreValue) 
          { 
        
              }
              if(progressionCMin < Score.ScoreValue) 
          { 
              if(Time.time > nextspawn) 
          { 
              nextspawn = Time.time + (SpawnRate);
              randx = Random.Range (-1.28f , 1.27f);
              spawnerSite = new Vector2 (randx , transform.position.y);
              Instantiate (enemy, spawnerSite,Quaternion.identity);
              
              }
        
              }
              

              if(progressionCMax < Score.ScoreValue) 
          { 
        if(Time.time > nextspawn) 
          { 
              nextspawn = Time.time + (SpawnRate*5);
              randx = Random.Range (-1.28f , 1.27f);
              spawnerSite = new Vector2 (randx , transform.position.y);
              Instantiate (enemy, spawnerSite,Quaternion.identity);
              
              }
              }
              if(1500 <= Score.ScoreValue) 
          { 
              nextspawn = Time.time + (SpawnRate*5);
              randx = Random.Range (-1.28f , 1.27f);
              spawnerSite = new Vector2 (randx , transform.position.y);
              Instantiate (nothing, spawnerSite,Quaternion.identity);
              
            }
    }
}
