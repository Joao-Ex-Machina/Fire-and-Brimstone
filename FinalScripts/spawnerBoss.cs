using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerBoss : MonoBehaviour
{
    public GameObject boss;
    Vector2 spawnerSite;
    bool SpawnerEnabled;
    void Update()
     {
         if (SpawnerEnabled == false && Score.ScoreValue >= 1500)
         {
             Spawn();
         }
     }
 
     
    

    void Spawn()
    {
          
            spawnerSite = new Vector2 (transform.position.x , transform.position.y);
              Instantiate (boss, spawnerSite, Quaternion.identity);
              SpawnerEnabled = true;
     }
 }
    
   

