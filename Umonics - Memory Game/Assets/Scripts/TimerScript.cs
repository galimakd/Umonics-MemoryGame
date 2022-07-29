using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI timerText;
    private float timer = 0f;
    private bool isTimerActive = true; 

    public void Stop(){
        isTimerActive = false;
    }

    private void FixedUpdate() {
        if(isTimerActive){
            Increment();
            UpdateText();
        }
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

    public int TimerInt{
        get{
            return (int)Mathf.Floor(timer);
        }
    }
}
