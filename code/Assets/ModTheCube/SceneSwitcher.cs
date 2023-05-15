using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    
    public void playGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    
}
