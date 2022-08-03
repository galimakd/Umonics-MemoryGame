public class VolumeSetting{
    private static VolumeSetting instance;

    private VolumeSetting(){}

    public static VolumeSetting GetInstance(){
        if(instance == null){
            instance = new VolumeSetting();
        }

        return instance;
    }

    private float volume = 1f;

    public float Volume{
        get{
            return volume;
        }

        set{
            this.volume = value;
        }
    }
}
