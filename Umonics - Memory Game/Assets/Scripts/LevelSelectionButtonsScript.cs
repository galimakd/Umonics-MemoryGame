using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelectionButtonsScript : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudioSource;
    [SerializeField] private AudioClip doorKnockClip;

    enum Difficulty{EASY, MEDIUM, HARD}

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
        StartCoroutine(LoadLevel(Difficulty.EASY));
    }

    /*
    public void MediumClicked(){
        StartCoroutine(LoadLevel(Difficulty.MEDIUM));
    }

     public void HardClicked(){
        StartCoroutine(LoadLevel(Difficulty.HARD));
    }
    */


    IEnumerator LoadLevel(Difficulty difficulty){
        buttonAudioSource.clip = doorKnockClip;
        buttonAudioSource.Play();
        yield return new WaitForSeconds(.1f);

        switch(difficulty){
            case Difficulty.EASY:
                SceneManager.LoadScene("EasyMode");
                break;
            case Difficulty.MEDIUM:
                //SceneManager.LoadScene("MediumMode");
                break;
            case Difficulty.HARD:
                //SceneManager.LoadScene("HardMode");
                break; 
        }
    }
    
}
