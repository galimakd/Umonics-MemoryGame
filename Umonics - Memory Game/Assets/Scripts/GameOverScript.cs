using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    
    public void RetryBackground() {
        gameObject.SetActive(true);
    }

    public void RestartButton() {
        SceneManager.LoadScene("EasyMode");
    }

    public void RestartButton2() {
        SceneManager.LoadScene("MediumMode");
    }
    
    public void MainMenuButton() {
        SceneManager.LoadScene("StartMenu");
    }

}
