using UnityEngine;

public class VolumeHandler : MonoBehaviour
{
    [SerializeField] private AudioSource[] sources;

    // Start is called before the first frame update
    void Start()
    {
        ManualUpdate();
    }

    public void ManualUpdate(){
        VolumeSetting volumeSetting = VolumeSetting.GetInstance();

        foreach(AudioSource source in sources){
            source.volume *= volumeSetting.Volume;
        }
    }
}
