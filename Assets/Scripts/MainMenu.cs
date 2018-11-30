using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartOption()
    {
        SceneManager.LoadScene("Main");
    }
    
    public void QuitOption()
    {
        Debug.Log("Game Quit!");
        Application.Quit();
    }
}
