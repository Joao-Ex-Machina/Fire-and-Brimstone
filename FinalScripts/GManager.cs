using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    public GameObject music;
    
    public void GameOver()
    {
        Destroy(music);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        
    }
      public void Victory()
    {
        Destroy(music);
         SceneManager.UnloadSceneAsync("Fire and Brimstone comp2");
        SceneManager.LoadScene("VictoryScene", LoadSceneMode.Single);
        
    }

  
}
