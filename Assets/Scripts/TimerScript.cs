using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 30f;
    public bool timeIsRunning = true;
    public TMP_Text timeText;

    void Start()
    {
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeIsRunning){
            if(timeRemaining >= 0){
                timeRemaining -= Time.deltaTime;
                Displaytime(timeRemaining);
            }
            else{
                    timeIsRunning = false;
                    timeRemaining = 0;
            }
        }
    }
        

    void Displaytime(float timeToDisplay){
        //timeToDisplay -= 1;
        float minutes = Mathf.FloorToInt(timeToDisplay/60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
