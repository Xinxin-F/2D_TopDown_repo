using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;

    public GameObject deatheScreen;

    public int score;
    public TextMeshProGUI scoreText;

    private void Awake(){
        manager = this;
    }

    // activate deathscreen
    public void GameOver(){
        deatheScreen.SetActive(true);
        scoreText.text = "Score" + score.ToString();
    }

    // load the current game scene
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncreaseScore(int amount){
        score += amount;
    }

}
