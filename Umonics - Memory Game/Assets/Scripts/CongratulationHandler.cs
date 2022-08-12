using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratulationHandler : MonoBehaviour
{
    [SerializeField] private GameObject confetti, congratsPanel;
    [SerializeField] private GameObject dialogStart;
    [SerializeField] private GameObject videoPanel, videoItself;

    public void CongratsCheckButtonClicked(){
        confetti.SetActive(false);
        congratsPanel.SetActive(false);

        dialogStart.SetActive(true);
    }

    public void DialogueCheckClicked(AudioSource source){
        StartCoroutine(CheckCoroutine(source));
    }

    IEnumerator CheckCoroutine(AudioSource source){
        source.Play();
        yield return new WaitForSeconds(.1f);

        dialogStart.SetActive(false);
        
        videoPanel.SetActive(true);
        videoItself.SetActive(true);
    }
}
