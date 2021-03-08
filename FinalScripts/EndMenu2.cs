using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu2 : MonoBehaviour
{
    // Start is called before the first frame update
   public void Retry()
    {
          SceneManager.UnloadSceneAsync("GameOver2");
           SceneManager.LoadScene("Fire and Brimstone comp3", LoadSceneMode.Single);
    }
    public void BacktoMenu()
    {
          SceneManager.UnloadSceneAsync("GameOver2");
           SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }

    
}
