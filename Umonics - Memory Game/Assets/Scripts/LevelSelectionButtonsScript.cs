using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelSelectionButtonsScript : MonoBehaviour
{

    public void BackClicked(){

        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "LevelSelection") {
            SceneManager.LoadScene("StartMenu");
        }
        else if(scene.name == "EasyMode"){
            SceneManager.LoadScene("LevelSelection");
        }
    }

    public void EasyClicked(){
        LoadLevel("Easy");
    }

    /*
    public void MediumClicked(){
        LoadLevel("Medium");
    }

     public void HardClicked(){
        LoadLevel("Hard");
    }
    */

    private void LoadLevel(string level){
        switch(level){
            case "Easy":
                SceneManager.LoadScene("EasyMode");
                break;
            case "Medium":
                //SceneManager.LoadScene("MediumMode");
                break;
            case "Hard":
                //SceneManager.LoadScene("HardMode");
                break; 
        }
    }


}
