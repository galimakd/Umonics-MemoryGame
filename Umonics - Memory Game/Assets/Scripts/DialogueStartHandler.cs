using UnityEngine;
using System.Collections;

public class DialogueStartHandler : MonoBehaviour
{
    private static bool isAccepted = false;
    [SerializeField] GameObject dialogStart;

    private void Start() {
        if(!isAccepted){
            dialogStart.SetActive(true);
        }
    }
    
    public void CheckClicked(AudioSource source){
        StartCoroutine(CheckCoroutine(source));
    }

    IEnumerator CheckCoroutine(AudioSource source){
        source.Play();
        yield return new WaitForSeconds(.1f);

        isAccepted = true;
        dialogStart.SetActive(false);
    }
}
