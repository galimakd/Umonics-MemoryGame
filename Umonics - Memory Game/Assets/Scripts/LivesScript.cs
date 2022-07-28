using UnityEngine;

public class LivesScript : MonoBehaviour
{
    [SerializeField] private GameObject[] livesFills;
    private int lives = 3;
    
    /*
    SceneControllerScript _sceneControllerScript;
    public GameObject MainCard;

    void Awake() {
        _sceneControllerScript = MainCard.GetComponent<SceneControllerScript>();
    }
    */
    public int Lives{
        get{
            return lives;
        }
    }

    public void ReduceLives(){
        lives--;

        for (int i = 0; i < livesFills.Length; i++)
        {
            if(i + 1 <= lives){
                livesFills[i].SetActive(true);
            }else{
                livesFills[i].SetActive(false);
            }
        }
    }
}
