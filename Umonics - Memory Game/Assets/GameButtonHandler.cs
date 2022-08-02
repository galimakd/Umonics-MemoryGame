using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonHandler : MonoBehaviour
{
   public void BackClicked(){
        SceneManager.LoadScene("LevelSelection");
    }
}
