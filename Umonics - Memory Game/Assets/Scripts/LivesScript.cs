using UnityEngine;

public class LivesScript : MonoBehaviour
{
    [SerializeField] private GameObject[] livesFills;
    private int lives = 3;

    private void FixedUpdate() {
        UpdateLives();
    }

    private void UpdateLives(){
        for (int i = 0; i < lives; i++)
        {
            if(i + 1 <= lives){
                livesFills[i].SetActive(true);
            }else{
                livesFills[i].SetActive(false);
            }
        }
    }

    public int Lives{
        get{
            return lives;
        }
    }

    public void ReduceLives(){
        lives--;
    }
}
