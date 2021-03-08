using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager2 : MonoBehaviour
{
    public GameObject music;
    
    public void GameOver2()
    {
        Destroy(music);
        SceneManager.LoadScene("GameOver2", LoadSceneMode.Single);
        
    }
      public void Victory()
    {
        Destroy(music);
         SceneManager.UnloadSceneAsync("Fire and Brimstone comp3");
        SceneManager.LoadSceneAsync("VictoryScene", LoadSceneMode.Single);
        
    }

  
}
