using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
   public void Replay()
    {
          SceneManager.UnloadSceneAsync("VictoryScene");
           SceneManager.LoadSceneAsync("CharacterSelection", LoadSceneMode.Single);
    }
    public void BacktoMenu()
    {
          SceneManager.UnloadSceneAsync("VictoryScene");
           SceneManager.LoadSceneAsync("StartScene", LoadSceneMode.Single);
    }

}
