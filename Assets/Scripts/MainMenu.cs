using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Ajout de cette ligne

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
    }
        public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
