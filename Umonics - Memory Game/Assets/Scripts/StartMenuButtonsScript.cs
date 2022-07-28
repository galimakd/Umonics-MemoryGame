using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtonsScript : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("LevelSelection");
    }

}
