using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{
     
    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
