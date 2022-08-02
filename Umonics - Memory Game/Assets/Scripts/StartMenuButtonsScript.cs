using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenuButtonsScript : MonoBehaviour
{

    [SerializeField] private AudioSource menuBGMSource;
    public static float BGMClipTime;
    [SerializeField] private GameObject about;

    public void Play(AudioSource source){
        StartCoroutine(PlayAction(source));
    }

    public void About(AudioSource source){
        source.Play();
        about.SetActive(true);
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

        BGMClipTime = menuBGMSource.time;
        SceneManager.LoadScene("LevelSelection");
    }

    public void AboutBack(AudioSource source){
        source.Play();
        about.SetActive(false);
    }

}
