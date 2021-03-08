using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Retry()
    {
          SceneManager.UnloadSceneAsync("GameOver");
           SceneManager.LoadSceneAsync("Fire and Brimstone comp2", LoadSceneMode.Single);
    }
    public void BacktoMenu()
    {
          SceneManager.UnloadSceneAsync("GameOver");
           SceneManager.LoadSceneAsync("StartScene", LoadSceneMode.Single);
    }

    
}
