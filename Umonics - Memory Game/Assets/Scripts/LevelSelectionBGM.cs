using UnityEngine;

public class LevelSelectionBGM : MonoBehaviour
{
    [SerializeField] private AudioSource mainCameraSource;

    void Start()
    {
        mainCameraSource.time = StartMenuButtonsScript.BGMClipTime;
        mainCameraSource.Play();
    }

}
