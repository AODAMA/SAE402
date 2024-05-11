using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{

    public string sceneName = "MainMenu";


    public GameObject GameOverUI;
    public PlayerData playerData;

    void Update () {
        if(playerData.currentHealth <= 0){
            Pause();
        }
    }

    public void Resume () {
        GameOverUI.SetActive(false);
    }

    void Pause() {
        GameOverUI.SetActive(true);
    }

        public void Reload()
    {
        GameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
