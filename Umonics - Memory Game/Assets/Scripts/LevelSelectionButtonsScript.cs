using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelectionButtonsScript : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudioSource;
    [SerializeField] private AudioClip doorKnockClip;

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
        StartCoroutine(LoadLevel("Easy"));
    }

    /*
    public void MediumClicked(){
        StartCoroutine(LoadLevel("Medium"));
    }

     public void HardClicked(){
        StartCoroutine(LoadLevel("Hard"));
    }
    */


    IEnumerator LoadLevel(string level){
        buttonAudioSource.clip = doorKnockClip;
        buttonAudioSource.Play();
        yield return new WaitWhile(() => buttonAudioSource.isPlaying);

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
