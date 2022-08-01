
using UnityEngine;

public class AudioSwitch : MonoBehaviour
{
    [SerializeField] private AudioSource mainBGMAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        mainBGMAudioSource.enabled = false;
    }

}
