using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
    public void BacktoMenuC()
    {
          SceneManager.UnloadSceneAsync("Credits");
           SceneManager.LoadSceneAsync("StartScene", LoadSceneMode.Single);
    }

}
