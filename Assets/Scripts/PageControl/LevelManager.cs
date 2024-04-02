using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


// public enum GameState{
//     menu, 
//     inGame, 
//     gameOver
// }
public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;

    public GameObject deatheScreen;

    public int score;
   // public TextMeshProUGUI scoreText;
    public SaveData data;

    private void Awake(){
        manager = this;
        SaveSystem.Initialise();
    }

    // activate deathscreen
    public void GameOver(){
        deatheScreen.SetActive(true);
        Time.timeScale = 0f;
        //scoreText.text = "Score" + score.ToString(); //update when lose
    }

    // load the current game scene
    public void RestartGameButton(){
        SceneManager.LoadScene("GameScene");
    }
    public void BackMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }

    public void IncreaseScore(int amount){
        score += amount;
        GameObject.FindObjectOfType<ScoreUI>().UpdateScore(); //update in GameScene
    }

    [System.Serializable] public class SaveData{
    public int highscore;
    public SaveData(int _hs){
        highscore = _hs;
    }
    }

    // public GameState currentGameState = GameState.menu;
    // public static LevelManager manager;
    //   private void Awake(){
    //     manager = this;
    //     SaveSystem.Initialise();
    // }

    // void Start(){
    //     StartGame();
    // }

    // public void StartGame(){
    //     SetGameState(GameState.inGame);
    // }

    // public void GameOver(){
    //     SetGameState(GameState.gameOver);
    // }

    // public BackToMenu(){
    //     SetGameState(GameState.menu);
    // }

    // void SetGameState(GameState newGameState){
    //     if(newGameState == GameState.menu){

    //     }
    //     else if (newGameState == GameState.inGame){

    //     }
    //     else if (newGameState == GameState.gameOver){

    //     }
    //     currentGameState = newGameState;


    // }
}

