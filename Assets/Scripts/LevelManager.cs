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
    public TextMeshProUGUI scoreText;
    

    private void Awake(){
        manager = this;
        SaveSystem.Initialise();
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
// [System.Serializable] public class SaveData{
//     public int highscore;
//     public SaveData(int _hs){
//         highscore = _hs;
//     }
// }