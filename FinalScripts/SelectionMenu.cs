using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionMenu : MonoBehaviour
{
     public void Beast()
    {
          SceneManager.UnloadSceneAsync("CharacterSelection");
           SceneManager.LoadSceneAsync("Fire and Brimstone comp2", LoadSceneMode.Single);
    }
     public void StormBird()
    {
          SceneManager.UnloadSceneAsync("CharacterSelection");
           SceneManager.LoadSceneAsync("Fire and Brimstone comp3", LoadSceneMode.Single);
    }
}
