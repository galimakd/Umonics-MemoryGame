using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TwoStarsScript : MonoBehaviour
{
    
    public void TwoStars() {
        gameObject.SetActive(true);
    }
    
    public void NextButton() {
        SceneManager.LoadScene("LevelSelection");
    }
    
    public void MainMenuButton() {
        SceneManager.LoadScene("StartMenu");
    }
}
