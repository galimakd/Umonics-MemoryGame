using UnityEngine;

public class VolumeHandler : MonoBehaviour
{
    [SerializeField] private AudioSource[] sources;
    private float[] initValues;

    // Start is called before the first frame update
    void Start()
    {
        initValues = new float[sources.Length];
        for(int i = 0; i < sources.Length; i++){
            initValues[i] = sources[i].volume;
        }
        ManualUpdate();
    }

    public void ManualUpdate(){
        VolumeSetting volumeSetting = VolumeSetting.GetInstance();

        for(int i = 0; i < sources.Length; i++){
            sources[i].volume = initValues[i] * volumeSetting.Volume;
        }
    }
}
