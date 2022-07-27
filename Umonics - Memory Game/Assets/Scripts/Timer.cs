using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timerText;
    private float timer = 0f;

    private void FixedUpdate() {
        Increment();
        UpdateText();
    }

    void Increment(){
        timer += Time.fixedDeltaTime;
    }

    void UpdateText(){
        
        timerText.text = TimerString;
    }

    public string TimerString{
        get{
            int minutes = Mathf.FloorToInt(timer / 60F);
            int seconds = Mathf.FloorToInt(timer % 60);
            return string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
