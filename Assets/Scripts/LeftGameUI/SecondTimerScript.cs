using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class SecondTimerScript : MonoBehaviour
{

    public float timeRemaining = 30f;
    public bool timeIsRunning = true;
    public TMP_Text timeText;

    void Start()
    {
        timeIsRunning = true;
    }


    void Update()
    {
        if(timeIsRunning && !PausePage.isPaused){
            if(timeRemaining > 0){
                timeRemaining -= Time.deltaTime;
                Displaytime(timeRemaining);
            }
            else{
                    timeRemaining = 0;
                    LevelManager.manager.SaveScore();
                    SceneManager.LoadScene("Winning Page");
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
