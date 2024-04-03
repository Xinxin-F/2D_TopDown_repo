using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class TimerScript : MonoBehaviour
{
    // public abstract class TimerScript : MonoBehaviour
    // {
    public float timeRemaining = 30f;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
    // public static TimerScript instance; 

    // protected virtual void OnTimerFinished()
    // {
    //     SceneManager.LoadScene("SecondMap");
    // }

    //  void Awake()
    // {
    //     if (instance != null)
    //     {
    //         Debug.LogWarning("More than one TimerScript instance found!");
    //         return;
    //     }
    //     instance = this;
    // }

    void Start()
    {
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeIsRunning && !PausePage.isPaused){
            if(timeRemaining > 0){
                timeRemaining -= Time.deltaTime;
                Displaytime(timeRemaining);
            }
            else{
                    // timeIsRunning = false;
                    timeRemaining = 0;
                    SceneManager.LoadScene("SecondMap");
                    //OnTimerFinished();
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
