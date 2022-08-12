using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThreeStarsScript : MonoBehaviour
{
    
    public void ThreeStars() {
        gameObject.SetActive(true);
    }
    
    public void EndButton() {
        SceneManager.LoadScene("Congratulations");
    }

    public void NextButton() {
        SceneManager.LoadScene("LevelSelection");
    }
    
    public void MainMenuButton() {
        SceneManager.LoadScene("StartMenu");
    }
}
