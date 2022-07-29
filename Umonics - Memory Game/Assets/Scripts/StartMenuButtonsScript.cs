using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtonsScript : MonoBehaviour
{
    public void Play(AudioSource source){
        source.Play();
        SceneManager.LoadScene("LevelSelection");

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

}
