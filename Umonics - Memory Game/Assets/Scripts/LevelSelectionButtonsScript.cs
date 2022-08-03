using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelectionButtonsScript : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudioSource;
    [SerializeField] private AudioClip doorKnockClip;
    private LevelSelectionDB levelSelectionDB;
    [SerializeField] private GameObject mediumLock, hardLock;
    
    enum Difficulty{EASY, MEDIUM, HARD}


    private void Start() {
        levelSelectionDB = LevelSelectionDB.GetInstance();

        // Lock thingy
        if(levelSelectionDB.LevelUnlocked >= 2){
            mediumLock.SetActive(false);
        }

         if(levelSelectionDB.LevelUnlocked == 3){
            hardLock.SetActive(false);
        }
    }

    public void BackClicked(){
        SceneManager.LoadScene("StartMenu");    
    }

    public void EasyClicked(){
        StartCoroutine(LoadLevel(Difficulty.EASY));
    }

    public void MediumClicked(){
        StartCoroutine(LoadLevel(Difficulty.MEDIUM));
    }

     public void HardClicked(){
        StartCoroutine(LoadLevel(Difficulty.HARD));
    }


    IEnumerator LoadLevel(Difficulty difficulty){
        buttonAudioSource.clip = doorKnockClip;
        buttonAudioSource.Play();
        yield return new WaitForSeconds(.1f);

        switch(difficulty){
            case Difficulty.EASY:
                SceneManager.LoadScene("EasyMode");
                break;
            case Difficulty.MEDIUM:
                if(levelSelectionDB.LevelUnlocked >= 2){
                    SceneManager.LoadScene("MediumMode");
                }
                break;
            case Difficulty.HARD:
                if(levelSelectionDB.LevelUnlocked >= 3){
                    //SceneManager.LoadScene("HardMode");
                }
                break; 
        }
    }
    
}
