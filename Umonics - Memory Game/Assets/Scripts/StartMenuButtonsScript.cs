using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class StartMenuButtonsScript : MonoBehaviour
{

    [SerializeField] private AudioSource menuBGMSource;
    public static float BGMClipTime;
    [SerializeField] private GameObject about;
    [SerializeField] private GameObject volume;
    private VolumeSetting volumeSetting;
    [SerializeField]private Slider volumeSlider;
    [SerializeField]private VolumeHandler volumeHandler;

    private void Start() {
        volumeSetting = VolumeSetting.GetInstance();
    }

    public void Play(AudioSource source){
        StartCoroutine(PlayAction(source));
    }

    public void About(AudioSource source){
        source.Play();
        about.SetActive(true);
    }

    public void Volume(AudioSource source){
        source.Play();
        volume.SetActive(true);
        volumeSlider.value = volumeSetting.Volume;
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

    public void VolumeSave(AudioSource source){
        source.Play();
        volumeSetting.Volume = volumeSlider.value;
        volumeHandler.ManualUpdate();
        volume.SetActive(false);
    }

    public void VolumeDiscard(AudioSource source){
        source.Play();
        volume.SetActive(false);
    }

}
