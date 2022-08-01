using System.Collections;
using UnityEngine;

public class LevelBGMChanger : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip mainBGM;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchAudio());
    }

    private IEnumerator SwitchAudio(){
        yield return new WaitForSeconds(.1f);

        source.clip = mainBGM;
        source.Play();
    }
}
