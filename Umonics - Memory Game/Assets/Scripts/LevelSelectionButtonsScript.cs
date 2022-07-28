using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionButtonsScript : MonoBehaviour
{
    public void BackClicked(){
        SceneManager.LoadScene("StartMenu");
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
