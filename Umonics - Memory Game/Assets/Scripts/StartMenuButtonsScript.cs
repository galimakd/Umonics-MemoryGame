using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenuButtonsScript : MonoBehaviour
{

    public void Play(AudioSource source){
        StartCoroutine(PlayAction(source));
    }

    public void HowToPlay(AudioSource source){
        source.Play();
    }

    public void Volume(AudioSource source){
        source.Play();
    }

    public void Quit(AudioSource source){
        source.Play();
    }

    private IEnumerator PlayAction(AudioSource source){
        source.Play();
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene("LevelSelection");
    }

}
