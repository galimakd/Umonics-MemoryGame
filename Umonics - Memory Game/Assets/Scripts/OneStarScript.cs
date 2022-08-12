using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OneStarScript : MonoBehaviour
{
    
    public void OneStar() {
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
