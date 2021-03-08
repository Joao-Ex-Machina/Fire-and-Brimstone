using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void play()
    {
          SceneManager.UnloadSceneAsync("StartScene");
           SceneManager.LoadSceneAsync("CharacterSelection", LoadSceneMode.Single);
    }
    public void Credits()
    {
          SceneManager.UnloadSceneAsync("StartScene");
           SceneManager.LoadSceneAsync("Credits", LoadSceneMode.Single);
    }
    public void Quit()
    {
          Application.Quit();
    }


}
