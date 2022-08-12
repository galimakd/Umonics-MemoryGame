using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelectionButtonsScript : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudioSource;
    [SerializeField] private AudioClip doorKnockClip, backClip;
    private LevelSelectionDB levelSelectionDB;
    [SerializeField] private GameObject mediumLock, hardLock;
    [SerializeField] private Animator mediumAnimator, hardAnimator;
    
    enum Difficulty{EASY, MEDIUM, HARD}

    private static bool isMedLock = true, isHardLock = true;

    private void Start() {
        levelSelectionDB = LevelSelectionDB.GetInstance();

        // Lock thingy
        if(isMedLock){
            if(levelSelectionDB.LevelUnlocked >= 2){ //unlocking
                isMedLock = false;
                mediumAnimator.Play("DoorLock_Unlocking", 0, 0);
                StartCoroutine(LockSetActiveFalse(mediumLock));
            }
        }else{ //already unlocked
            mediumLock.SetActive(false);
        }

        if(isHardLock){
            if(levelSelectionDB.LevelUnlocked == 3){ //unlocking
                isHardLock = false;
                hardAnimator.Play("DoorLock_Unlocking", 0, 0);
                StartCoroutine(LockSetActiveFalse(hardLock));
            }
        }else{ //already unlocked
            hardLock.SetActive(false);
        }

        
    }

    IEnumerator LockSetActiveFalse(GameObject lockToDisable){
        yield return new WaitForSeconds(1.4f);
        lockToDisable.SetActive(false);
    }

    public void BackClicked(){
         StartCoroutine(GoBack());
    }

    IEnumerator GoBack(){
        buttonAudioSource.clip = backClip;
        buttonAudioSource.Play();
        yield return new WaitForSeconds(.1f);

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
                    SceneManager.LoadScene("HardMode");
                }
                break; 
        }
    }
    
}
